﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace revashare_svc_webapi.Client.RevaShareServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoleDAO", Namespace="http://schemas.datacontract.org/2004/07/RevaShare.DataClient.Models")]
    [System.SerializableAttribute()]
    public partial class RoleDAO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
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
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RevaShareServiceReference.IRevaShareDataService")]
    public interface IRevaShareDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/passUser", ReplyAction="http://tempuri.org/IRevaShareDataService/passUserResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO passUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/passUser", ReplyAction="http://tempuri.org/IRevaShareDataService/passUserResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO> passUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/logIn", ReplyAction="http://tempuri.org/IRevaShareDataService/logInResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO logIn();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/logIn", ReplyAction="http://tempuri.org/IRevaShareDataService/logInResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO> logInAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/register", ReplyAction="http://tempuri.org/IRevaShareDataService/registerResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO register();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/register", ReplyAction="http://tempuri.org/IRevaShareDataService/registerResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO> registerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetApartment", ReplyAction="http://tempuri.org/IRevaShareDataService/GetApartmentResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO GetApartment(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetApartment", ReplyAction="http://tempuri.org/IRevaShareDataService/GetApartmentResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO> GetApartmentAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetApartmentByName", ReplyAction="http://tempuri.org/IRevaShareDataService/GetApartmentByNameResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO GetApartmentByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetApartmentByName", ReplyAction="http://tempuri.org/IRevaShareDataService/GetApartmentByNameResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO> GetApartmentByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/passRide", ReplyAction="http://tempuri.org/IRevaShareDataService/passRideResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO passRide();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/passRide", ReplyAction="http://tempuri.org/IRevaShareDataService/passRideResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO> passRideAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/AddRide", ReplyAction="http://tempuri.org/IRevaShareDataService/AddRideResponse")]
        bool AddRide(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/AddRide", ReplyAction="http://tempuri.org/IRevaShareDataService/AddRideResponse")]
        System.Threading.Tasks.Task<bool> AddRideAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/UpdateRide", ReplyAction="http://tempuri.org/IRevaShareDataService/UpdateRideResponse")]
        bool UpdateRide(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/UpdateRide", ReplyAction="http://tempuri.org/IRevaShareDataService/UpdateRideResponse")]
        System.Threading.Tasks.Task<bool> UpdateRideAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/DeleteRide", ReplyAction="http://tempuri.org/IRevaShareDataService/DeleteRideResponse")]
        bool DeleteRide(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/DeleteRide", ReplyAction="http://tempuri.org/IRevaShareDataService/DeleteRideResponse")]
        System.Threading.Tasks.Task<bool> DeleteRideAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetRideRiders", ReplyAction="http://tempuri.org/IRevaShareDataService/GetRideRidersResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO[] GetRideRiders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetRideRiders", ReplyAction="http://tempuri.org/IRevaShareDataService/GetRideRidersResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO[]> GetRideRidersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetRideRiderById", ReplyAction="http://tempuri.org/IRevaShareDataService/GetRideRiderByIdResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO GetRideRiderById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetRideRiderById", ReplyAction="http://tempuri.org/IRevaShareDataService/GetRideRiderByIdResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO> GetRideRiderByIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/passRideRider", ReplyAction="http://tempuri.org/IRevaShareDataService/passRideRiderResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO passRideRider();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/passRideRider", ReplyAction="http://tempuri.org/IRevaShareDataService/passRideRiderResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO> passRideRiderAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/AddRideRiders", ReplyAction="http://tempuri.org/IRevaShareDataService/AddRideRidersResponse")]
        bool AddRideRiders(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride, revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO rideriders);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/AddRideRiders", ReplyAction="http://tempuri.org/IRevaShareDataService/AddRideRidersResponse")]
        System.Threading.Tasks.Task<bool> AddRideRidersAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride, revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO rideriders);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/UpdateRideRider", ReplyAction="http://tempuri.org/IRevaShareDataService/UpdateRideRiderResponse")]
        bool UpdateRideRider(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/UpdateRideRider", ReplyAction="http://tempuri.org/IRevaShareDataService/UpdateRideRiderResponse")]
        System.Threading.Tasks.Task<bool> UpdateRideRiderAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/DeleteRideRider", ReplyAction="http://tempuri.org/IRevaShareDataService/DeleteRideRiderResponse")]
        bool DeleteRideRider(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/DeleteRideRider", ReplyAction="http://tempuri.org/IRevaShareDataService/DeleteRideRiderResponse")]
        System.Threading.Tasks.Task<bool> DeleteRideRiderAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetVehicleById", ReplyAction="http://tempuri.org/IRevaShareDataService/GetVehicleByIdResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO GetVehicleById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetVehicleById", ReplyAction="http://tempuri.org/IRevaShareDataService/GetVehicleByIdResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO> GetVehicleByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/AddVehicle", ReplyAction="http://tempuri.org/IRevaShareDataService/AddVehicleResponse")]
        bool AddVehicle(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/AddVehicle", ReplyAction="http://tempuri.org/IRevaShareDataService/AddVehicleResponse")]
        System.Threading.Tasks.Task<bool> AddVehicleAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/UpdateVehicle", ReplyAction="http://tempuri.org/IRevaShareDataService/UpdateVehicleResponse")]
        bool UpdateVehicle(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/UpdateVehicle", ReplyAction="http://tempuri.org/IRevaShareDataService/UpdateVehicleResponse")]
        System.Threading.Tasks.Task<bool> UpdateVehicleAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/DeleteVehicle", ReplyAction="http://tempuri.org/IRevaShareDataService/DeleteVehicleResponse")]
        bool DeleteVehicle(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/DeleteVehicle", ReplyAction="http://tempuri.org/IRevaShareDataService/DeleteVehicleResponse")]
        System.Threading.Tasks.Task<bool> DeleteVehicleAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRevaShareDataServiceChannel : revashare_svc_webapi.Client.RevaShareServiceReference.IRevaShareDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RevaShareDataServiceClient : System.ServiceModel.ClientBase<revashare_svc_webapi.Client.RevaShareServiceReference.IRevaShareDataService>, revashare_svc_webapi.Client.RevaShareServiceReference.IRevaShareDataService {
        
        public RevaShareDataServiceClient() {
        }
        
        public RevaShareDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RevaShareDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RevaShareDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RevaShareDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO passUser() {
            return base.Channel.passUser();
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO> passUserAsync() {
            return base.Channel.passUserAsync();
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO logIn() {
            return base.Channel.logIn();
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO> logInAsync() {
            return base.Channel.logInAsync();
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO register() {
            return base.Channel.register();
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO> registerAsync() {
            return base.Channel.registerAsync();
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO GetApartment(int id) {
            return base.Channel.GetApartment(id);
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO> GetApartmentAsync(int id) {
            return base.Channel.GetApartmentAsync(id);
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO GetApartmentByName(string name) {
            return base.Channel.GetApartmentByName(name);
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO> GetApartmentByNameAsync(string name) {
            return base.Channel.GetApartmentByNameAsync(name);
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO passRide() {
            return base.Channel.passRide();
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO> passRideAsync() {
            return base.Channel.passRideAsync();
        }
        
        public bool AddRide(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride) {
            return base.Channel.AddRide(ride);
        }
        
        public System.Threading.Tasks.Task<bool> AddRideAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride) {
            return base.Channel.AddRideAsync(ride);
        }
        
        public bool UpdateRide(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride) {
            return base.Channel.UpdateRide(ride);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateRideAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride) {
            return base.Channel.UpdateRideAsync(ride);
        }
        
        public bool DeleteRide(string id) {
            return base.Channel.DeleteRide(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteRideAsync(string id) {
            return base.Channel.DeleteRideAsync(id);
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO[] GetRideRiders() {
            return base.Channel.GetRideRiders();
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO[]> GetRideRidersAsync() {
            return base.Channel.GetRideRidersAsync();
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO GetRideRiderById(string id) {
            return base.Channel.GetRideRiderById(id);
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO> GetRideRiderByIdAsync(string id) {
            return base.Channel.GetRideRiderByIdAsync(id);
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO passRideRider() {
            return base.Channel.passRideRider();
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO> passRideRiderAsync() {
            return base.Channel.passRideRiderAsync();
        }
        
        public bool AddRideRiders(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride, revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO rideriders) {
            return base.Channel.AddRideRiders(ride, rideriders);
        }
        
        public System.Threading.Tasks.Task<bool> AddRideRidersAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride, revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO rideriders) {
            return base.Channel.AddRideRidersAsync(ride, rideriders);
        }
        
        public bool UpdateRideRider(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider) {
            return base.Channel.UpdateRideRider(riderider);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateRideRiderAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider) {
            return base.Channel.UpdateRideRiderAsync(riderider);
        }
        
        public bool DeleteRideRider(string id) {
            return base.Channel.DeleteRideRider(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteRideRiderAsync(string id) {
            return base.Channel.DeleteRideRiderAsync(id);
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO GetVehicleById(int id) {
            return base.Channel.GetVehicleById(id);
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO> GetVehicleByIdAsync(int id) {
            return base.Channel.GetVehicleByIdAsync(id);
        }
        
        public bool AddVehicle(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle) {
            return base.Channel.AddVehicle(vehicle);
        }
        
        public System.Threading.Tasks.Task<bool> AddVehicleAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle) {
            return base.Channel.AddVehicleAsync(vehicle);
        }
        
        public bool UpdateVehicle(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle) {
            return base.Channel.UpdateVehicle(vehicle);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateVehicleAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle) {
            return base.Channel.UpdateVehicleAsync(vehicle);
        }
        
        public bool DeleteVehicle(int id) {
            return base.Channel.DeleteVehicle(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteVehicleAsync(int id) {
            return base.Channel.DeleteVehicleAsync(id);
        }
    }
}
