using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_Projekt6_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly ReservationService.Service1Client service = new ReservationService.Service1Client();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddShow_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = (DateTime)DatePickerAdd.SelectedDate;

            DateTime dthours = new DateTime();
            DateTime dateTime = new DateTime();

            try
            {
                double hour = Convert.ToDouble(TextBoxHour.Text);
                double minute = Convert.ToDouble(TextBoxMinute.Text);

                if (hour > 23 || hour < 0 || minute > 59 || minute < 0)
                {
                    //neprovede vlozeni, pokud zadany cas nebude v ramci jednoho dne
                    return;
                }

                dthours = date.AddHours(hour);
                dateTime = dthours.AddMinutes(minute);
            }
            catch
            {
                //neprovede vlozeni, kdyz zadany cas nebude parsovatelny
                return;
            }
            
            if (service.AddShow(dateTime, TextBoxShowName.Text)) //vraci bool, muze se hodit do podminky
            {
                MessageBox.Show("Představení úspěšně přidáno!", "Upozornění");
            }

            //REINICIALIZACE
            TextBoxHour.Text = "HH";
            TextBoxMinute.Text = "MM";
            TextBoxShowName.Text = "";
        }

        private void ButtonRemoveShow_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = (DateTime)DatePickerRemove.SelectedDate;
            DateTime dthours = new DateTime();
            DateTime dateTime = new DateTime();

            try
            {
                double hour = Convert.ToDouble(TextBoxHourRemove.Text);
                double minute = Convert.ToDouble(TextBoxMinuteRemove.Text);

                if (hour > 23 || hour < 0 || minute > 59 || minute < 0)
                {
                    return;
                }

                dthours = date.AddHours(hour);
                dateTime = dthours.AddMinutes(minute);
            }
            catch
            {
                //neprovede odebrani, kdyz zadany cas nebude parsovatelny
                return;
            }

            if (service.DeleteShow(dateTime)) //vraci bool, muze se hodit do podminky
            {
                MessageBox.Show("Představení úspěšně odstraněno!", "Upozornění");
            }

            //REINICIALIZACE
            TextBoxHourRemove.Text = "HH";
            TextBoxMinuteRemove.Text = "MM";
            LabelShowNameRemove.Content = "";
        }

        private void DatePickerRemove_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = (DateTime)DatePickerRemove.SelectedDate;
            DateTime dthours = new DateTime();
            DateTime dateTime = new DateTime();

            try
            {
                double hour = Convert.ToDouble(TextBoxHourRemove.Text);
                double minute = Convert.ToDouble(TextBoxMinuteRemove.Text);

                if (hour > 23 || hour < 0 || minute > 59 || minute < 0)
                {
                    return;
                }

                dthours = date.AddHours(hour);
                dateTime = dthours.AddMinutes(minute);
            }
            catch
            {
                //neprovede akci
                return;
            }



            Dictionary<DateTime, string> shows = service.GetShowsByDate(dateTime);

            foreach (var show in shows)
            {
                if (show.Key.Equals(dateTime))
                {
                    LabelShowNameRemove.Content = show.Value;
                }
            }
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Dictionary<DateTime, string> shows = service.GetShowsByDate((DateTime)DatePicker.SelectedDate);

            ComboBoxAvailableShows.Items.Clear();

            foreach (var show in shows)
            {
                ComboBoxAvailableShows.Items.Add(show.Key.ToString("f") + ", "+ show.Value);
            }
        }

        private void ComboBoxAvailableShows_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxAvailableShows.SelectedItem == null)
            {
                return;
            }

            string[] temp = ComboBoxAvailableShows.SelectedItem.ToString().Split(',');
            temp[1].Trim();

            LabelDateTime.Content = temp[0];

            LabelShowName.Content = temp[1];

            UpdateFreeSeats();

            UpdateColours();
        }

        private static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxAvailableShows.SelectedItem == null)
            {
                return;
            }

            Button button = (Button)sender;

            if(button.Background.Equals(Brushes.Red))
            {
                ButtonMakeReservation.IsEnabled = false;
                ButtonCancelReservation.IsEnabled = true;

                LabelSeatNumber.Content = button.Content;

                LabelSeatState.Content = "Obsazeno";

                string[] temp = ComboBoxAvailableShows.SelectedItem.ToString().Split(',');
                TextBoxReservationName.Text = service.GetReservationName(Convert.ToDateTime(temp[0]), Convert.ToInt32(button.Content));
            }
            else
            {
                ButtonMakeReservation.IsEnabled = true;
                ButtonCancelReservation.IsEnabled = false;

                LabelSeatNumber.Content = button.Content;

                LabelSeatState.Content = "Volno";

                TextBoxReservationName.Text = "";
            }
        }

        private void ButtonMakeReservation_Click(object sender, RoutedEventArgs e)
        {
            string[] temp = ComboBoxAvailableShows.SelectedItem.ToString().Split(',');

            if(service.MakeReservation(Convert.ToDateTime(temp[0]), Convert.ToInt32(LabelSeatNumber.Content), TextBoxReservationName.Text))
            {
                MessageBox.Show("Rezervace proběhla úspěšně!", "Upozornění");
                UpdateColours();
                TextBoxReservationName.Text = "";
            }

            UpdateFreeSeats();
        }

        private void UpdateColours()
        {
            string[] temp = ComboBoxAvailableShows.SelectedItem.ToString().Split(',');
            Dictionary<int, bool?> seats = service.GetSeatingInfo(Convert.ToDateTime(temp[0]));

            int i = 0;
            foreach (Button button in FindVisualChildren<Button>(Seats))
            {
                if (seats.ElementAt(i).Value == false)
                {
                    button.Background = Brushes.Lime;
                }
                else button.Background = Brushes.Red;
                i++;
            }
        }

        private void ButtonCancelReservation_Click(object sender, RoutedEventArgs e)
        {
            string[] temp = ComboBoxAvailableShows.SelectedItem.ToString().Split(',');

            if (service.CancelReservation(Convert.ToDateTime(temp[0]), Convert.ToInt32(LabelSeatNumber.Content)))
            {
                MessageBox.Show("Rezervace byla úspěšně zrušena!", "Upozornění");
                UpdateColours();
                TextBoxReservationName.Text = "";
            }

            UpdateFreeSeats();
        }

        private void UpdateFreeSeats()
        {
            string[] temp = ComboBoxAvailableShows.SelectedItem.ToString().Split(',');
            Dictionary<int, bool?> seats = service.GetSeatingInfo(Convert.ToDateTime(temp[0]));

            var count =
                from all in seats
                where all.Value == false
                group all by all.Value into free
                select free.Count();

            LabelFreeSeats.Content = count.First().ToString();
        }
    }
}
