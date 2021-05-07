﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOP_Projekt6_App.ReservationService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/OOP_Projekt6_WebService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReservationService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        OOP_Projekt6_App.ReservationService.CompositeType GetDataUsingDataContract(OOP_Projekt6_App.ReservationService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<OOP_Projekt6_App.ReservationService.CompositeType> GetDataUsingDataContractAsync(OOP_Projekt6_App.ReservationService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddShow", ReplyAction="http://tempuri.org/IService1/AddShowResponse")]
        bool AddShow(System.DateTime dateTime, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddShow", ReplyAction="http://tempuri.org/IService1/AddShowResponse")]
        System.Threading.Tasks.Task<bool> AddShowAsync(System.DateTime dateTime, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteShow", ReplyAction="http://tempuri.org/IService1/DeleteShowResponse")]
        bool DeleteShow(System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteShow", ReplyAction="http://tempuri.org/IService1/DeleteShowResponse")]
        System.Threading.Tasks.Task<bool> DeleteShowAsync(System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSeatingInfo", ReplyAction="http://tempuri.org/IService1/GetSeatingInfoResponse")]
        System.Collections.Generic.Dictionary<int, System.Nullable<bool>> GetSeatingInfo(System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSeatingInfo", ReplyAction="http://tempuri.org/IService1/GetSeatingInfoResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, System.Nullable<bool>>> GetSeatingInfoAsync(System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetReservationName", ReplyAction="http://tempuri.org/IService1/GetReservationNameResponse")]
        string GetReservationName(System.DateTime dateTime, int seat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetReservationName", ReplyAction="http://tempuri.org/IService1/GetReservationNameResponse")]
        System.Threading.Tasks.Task<string> GetReservationNameAsync(System.DateTime dateTime, int seat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetShows", ReplyAction="http://tempuri.org/IService1/GetShowsResponse")]
        System.Collections.Generic.Dictionary<System.DateTime, string> GetShows();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetShows", ReplyAction="http://tempuri.org/IService1/GetShowsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.DateTime, string>> GetShowsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetShowsByName", ReplyAction="http://tempuri.org/IService1/GetShowsByNameResponse")]
        System.Collections.Generic.Dictionary<System.DateTime, string> GetShowsByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetShowsByName", ReplyAction="http://tempuri.org/IService1/GetShowsByNameResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.DateTime, string>> GetShowsByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetShowsByDate", ReplyAction="http://tempuri.org/IService1/GetShowsByDateResponse")]
        System.Collections.Generic.Dictionary<System.DateTime, string> GetShowsByDate(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetShowsByDate", ReplyAction="http://tempuri.org/IService1/GetShowsByDateResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.DateTime, string>> GetShowsByDateAsync(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MakeReservation", ReplyAction="http://tempuri.org/IService1/MakeReservationResponse")]
        bool MakeReservation(System.DateTime dateTime, int seat, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MakeReservation", ReplyAction="http://tempuri.org/IService1/MakeReservationResponse")]
        System.Threading.Tasks.Task<bool> MakeReservationAsync(System.DateTime dateTime, int seat, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CancelReservation", ReplyAction="http://tempuri.org/IService1/CancelReservationResponse")]
        bool CancelReservation(System.DateTime dateTime, int seat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CancelReservation", ReplyAction="http://tempuri.org/IService1/CancelReservationResponse")]
        System.Threading.Tasks.Task<bool> CancelReservationAsync(System.DateTime dateTime, int seat);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : OOP_Projekt6_App.ReservationService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<OOP_Projekt6_App.ReservationService.IService1>, OOP_Projekt6_App.ReservationService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public OOP_Projekt6_App.ReservationService.CompositeType GetDataUsingDataContract(OOP_Projekt6_App.ReservationService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<OOP_Projekt6_App.ReservationService.CompositeType> GetDataUsingDataContractAsync(OOP_Projekt6_App.ReservationService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public bool AddShow(System.DateTime dateTime, string name) {
            return base.Channel.AddShow(dateTime, name);
        }
        
        public System.Threading.Tasks.Task<bool> AddShowAsync(System.DateTime dateTime, string name) {
            return base.Channel.AddShowAsync(dateTime, name);
        }
        
        public bool DeleteShow(System.DateTime dateTime) {
            return base.Channel.DeleteShow(dateTime);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteShowAsync(System.DateTime dateTime) {
            return base.Channel.DeleteShowAsync(dateTime);
        }
        
        public System.Collections.Generic.Dictionary<int, System.Nullable<bool>> GetSeatingInfo(System.DateTime dateTime) {
            return base.Channel.GetSeatingInfo(dateTime);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, System.Nullable<bool>>> GetSeatingInfoAsync(System.DateTime dateTime) {
            return base.Channel.GetSeatingInfoAsync(dateTime);
        }
        
        public string GetReservationName(System.DateTime dateTime, int seat) {
            return base.Channel.GetReservationName(dateTime, seat);
        }
        
        public System.Threading.Tasks.Task<string> GetReservationNameAsync(System.DateTime dateTime, int seat) {
            return base.Channel.GetReservationNameAsync(dateTime, seat);
        }
        
        public System.Collections.Generic.Dictionary<System.DateTime, string> GetShows() {
            return base.Channel.GetShows();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.DateTime, string>> GetShowsAsync() {
            return base.Channel.GetShowsAsync();
        }
        
        public System.Collections.Generic.Dictionary<System.DateTime, string> GetShowsByName(string name) {
            return base.Channel.GetShowsByName(name);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.DateTime, string>> GetShowsByNameAsync(string name) {
            return base.Channel.GetShowsByNameAsync(name);
        }
        
        public System.Collections.Generic.Dictionary<System.DateTime, string> GetShowsByDate(System.DateTime date) {
            return base.Channel.GetShowsByDate(date);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.DateTime, string>> GetShowsByDateAsync(System.DateTime date) {
            return base.Channel.GetShowsByDateAsync(date);
        }
        
        public bool MakeReservation(System.DateTime dateTime, int seat, string name) {
            return base.Channel.MakeReservation(dateTime, seat, name);
        }
        
        public System.Threading.Tasks.Task<bool> MakeReservationAsync(System.DateTime dateTime, int seat, string name) {
            return base.Channel.MakeReservationAsync(dateTime, seat, name);
        }
        
        public bool CancelReservation(System.DateTime dateTime, int seat) {
            return base.Channel.CancelReservation(dateTime, seat);
        }
        
        public System.Threading.Tasks.Task<bool> CancelReservationAsync(System.DateTime dateTime, int seat) {
            return base.Channel.CancelReservationAsync(dateTime, seat);
        }
    }
}
