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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetApartmentByName", ReplyAction="http://tempuri.org/IRevaShareDataService/GetApartmentByNameResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO GetApartmentByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetApartmentByName", ReplyAction="http://tempuri.org/IRevaShareDataService/GetApartmentByNameResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO> GetApartmentByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/AddApartment", ReplyAction="http://tempuri.org/IRevaShareDataService/AddApartmentResponse")]
        bool AddApartment(revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO apartment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/AddApartment", ReplyAction="http://tempuri.org/IRevaShareDataService/AddApartmentResponse")]
        System.Threading.Tasks.Task<bool> AddApartmentAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO apartment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/ListApartments", ReplyAction="http://tempuri.org/IRevaShareDataService/ListApartmentsResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO[] ListApartments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/ListApartments", ReplyAction="http://tempuri.org/IRevaShareDataService/ListApartmentsResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO[]> ListApartmentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/UpdateApartment", ReplyAction="http://tempuri.org/IRevaShareDataService/UpdateApartmentResponse")]
        bool UpdateApartment(revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO apartment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/UpdateApartment", ReplyAction="http://tempuri.org/IRevaShareDataService/UpdateApartmentResponse")]
        System.Threading.Tasks.Task<bool> UpdateApartmentAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO apartment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/DeleteApartment", ReplyAction="http://tempuri.org/IRevaShareDataService/DeleteApartmentResponse")]
        bool DeleteApartment(revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO apartment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/DeleteApartment", ReplyAction="http://tempuri.org/IRevaShareDataService/DeleteApartmentResponse")]
        System.Threading.Tasks.Task<bool> DeleteApartmentAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO apartment);
        
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
        bool DeleteRide(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/DeleteRide", ReplyAction="http://tempuri.org/IRevaShareDataService/DeleteRideResponse")]
        System.Threading.Tasks.Task<bool> DeleteRideAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetRideRiders", ReplyAction="http://tempuri.org/IRevaShareDataService/GetRideRidersResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO[] GetRideRiders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetRideRiders", ReplyAction="http://tempuri.org/IRevaShareDataService/GetRideRidersResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO[]> GetRideRidersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/passRideRider", ReplyAction="http://tempuri.org/IRevaShareDataService/passRideRiderResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO passRideRider();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/passRideRider", ReplyAction="http://tempuri.org/IRevaShareDataService/passRideRiderResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO> passRideRiderAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/AddRideRiders", ReplyAction="http://tempuri.org/IRevaShareDataService/AddRideRidersResponse")]
        bool AddRideRiders(revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO user, revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/AddRideRiders", ReplyAction="http://tempuri.org/IRevaShareDataService/AddRideRidersResponse")]
        System.Threading.Tasks.Task<bool> AddRideRidersAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO user, revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/UpdateRideRider", ReplyAction="http://tempuri.org/IRevaShareDataService/UpdateRideRiderResponse")]
        bool UpdateRideRider(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/UpdateRideRider", ReplyAction="http://tempuri.org/IRevaShareDataService/UpdateRideRiderResponse")]
        System.Threading.Tasks.Task<bool> UpdateRideRiderAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/Accept", ReplyAction="http://tempuri.org/IRevaShareDataService/AcceptResponse")]
        bool Accept(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/Accept", ReplyAction="http://tempuri.org/IRevaShareDataService/AcceptResponse")]
        System.Threading.Tasks.Task<bool> AcceptAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/DeleteRideRider", ReplyAction="http://tempuri.org/IRevaShareDataService/DeleteRideRiderResponse")]
        bool DeleteRideRider(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/DeleteRideRider", ReplyAction="http://tempuri.org/IRevaShareDataService/DeleteRideRiderResponse")]
        System.Threading.Tasks.Task<bool> DeleteRideRiderAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/AddVehicle", ReplyAction="http://tempuri.org/IRevaShareDataService/AddVehicleResponse")]
        bool AddVehicle(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/AddVehicle", ReplyAction="http://tempuri.org/IRevaShareDataService/AddVehicleResponse")]
        System.Threading.Tasks.Task<bool> AddVehicleAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/UpdateVehicle", ReplyAction="http://tempuri.org/IRevaShareDataService/UpdateVehicleResponse")]
        bool UpdateVehicle(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/UpdateVehicle", ReplyAction="http://tempuri.org/IRevaShareDataService/UpdateVehicleResponse")]
        System.Threading.Tasks.Task<bool> UpdateVehicleAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/DeleteVehicle", ReplyAction="http://tempuri.org/IRevaShareDataService/DeleteVehicleResponse")]
        bool DeleteVehicle(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/DeleteVehicle", ReplyAction="http://tempuri.org/IRevaShareDataService/DeleteVehicleResponse")]
        System.Threading.Tasks.Task<bool> DeleteVehicleAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/CreateFlag", ReplyAction="http://tempuri.org/IRevaShareDataService/CreateFlagResponse")]
        bool CreateFlag(revashare_svc_webapi.Logic.RevaShareServiceReference.FlagDAO flag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/CreateFlag", ReplyAction="http://tempuri.org/IRevaShareDataService/CreateFlagResponse")]
        System.Threading.Tasks.Task<bool> CreateFlagAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.FlagDAO flag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetFlagByID", ReplyAction="http://tempuri.org/IRevaShareDataService/GetFlagByIDResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.FlagDAO GetFlagByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetFlagByID", ReplyAction="http://tempuri.org/IRevaShareDataService/GetFlagByIDResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.FlagDAO> GetFlagByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetAllFlags", ReplyAction="http://tempuri.org/IRevaShareDataService/GetAllFlagsResponse")]
        revashare_svc_webapi.Logic.RevaShareServiceReference.FlagDAO[] GetAllFlags();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRevaShareDataService/GetAllFlags", ReplyAction="http://tempuri.org/IRevaShareDataService/GetAllFlagsResponse")]
        System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.FlagDAO[]> GetAllFlagsAsync();
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
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO GetApartmentByName(string name) {
            return base.Channel.GetApartmentByName(name);
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO> GetApartmentByNameAsync(string name) {
            return base.Channel.GetApartmentByNameAsync(name);
        }
        
        public bool AddApartment(revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO apartment) {
            return base.Channel.AddApartment(apartment);
        }
        
        public System.Threading.Tasks.Task<bool> AddApartmentAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO apartment) {
            return base.Channel.AddApartmentAsync(apartment);
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO[] ListApartments() {
            return base.Channel.ListApartments();
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO[]> ListApartmentsAsync() {
            return base.Channel.ListApartmentsAsync();
        }
        
        public bool UpdateApartment(revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO apartment) {
            return base.Channel.UpdateApartment(apartment);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateApartmentAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO apartment) {
            return base.Channel.UpdateApartmentAsync(apartment);
        }
        
        public bool DeleteApartment(revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO apartment) {
            return base.Channel.DeleteApartment(apartment);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteApartmentAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.ApartmentDAO apartment) {
            return base.Channel.DeleteApartmentAsync(apartment);
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
        
        public bool DeleteRide(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride) {
            return base.Channel.DeleteRide(ride);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteRideAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride) {
            return base.Channel.DeleteRideAsync(ride);
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO[] GetRideRiders() {
            return base.Channel.GetRideRiders();
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO[]> GetRideRidersAsync() {
            return base.Channel.GetRideRidersAsync();
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO passRideRider() {
            return base.Channel.passRideRider();
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO> passRideRiderAsync() {
            return base.Channel.passRideRiderAsync();
        }
        
        public bool AddRideRiders(revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO user, revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride) {
            return base.Channel.AddRideRiders(user, ride);
        }
        
        public System.Threading.Tasks.Task<bool> AddRideRidersAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.UserDAO user, revashare_svc_webapi.Logic.RevaShareServiceReference.RideDAO ride) {
            return base.Channel.AddRideRidersAsync(user, ride);
        }
        
        public bool UpdateRideRider(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider) {
            return base.Channel.UpdateRideRider(riderider);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateRideRiderAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider) {
            return base.Channel.UpdateRideRiderAsync(riderider);
        }
        
        public bool Accept(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider) {
            return base.Channel.Accept(riderider);
        }
        
        public System.Threading.Tasks.Task<bool> AcceptAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider) {
            return base.Channel.AcceptAsync(riderider);
        }
        
        public bool DeleteRideRider(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider) {
            return base.Channel.DeleteRideRider(riderider);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteRideRiderAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.RideRidersDAO riderider) {
            return base.Channel.DeleteRideRiderAsync(riderider);
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
        
        public bool DeleteVehicle(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle) {
            return base.Channel.DeleteVehicle(vehicle);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteVehicleAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.VehicleDAO vehicle) {
            return base.Channel.DeleteVehicleAsync(vehicle);
        }
        
        public bool CreateFlag(revashare_svc_webapi.Logic.RevaShareServiceReference.FlagDAO flag) {
            return base.Channel.CreateFlag(flag);
        }
        
        public System.Threading.Tasks.Task<bool> CreateFlagAsync(revashare_svc_webapi.Logic.RevaShareServiceReference.FlagDAO flag) {
            return base.Channel.CreateFlagAsync(flag);
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.FlagDAO GetFlagByID(int id) {
            return base.Channel.GetFlagByID(id);
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.FlagDAO> GetFlagByIDAsync(int id) {
            return base.Channel.GetFlagByIDAsync(id);
        }
        
        public revashare_svc_webapi.Logic.RevaShareServiceReference.FlagDAO[] GetAllFlags() {
            return base.Channel.GetAllFlags();
        }
        
        public System.Threading.Tasks.Task<revashare_svc_webapi.Logic.RevaShareServiceReference.FlagDAO[]> GetAllFlagsAsync() {
            return base.Channel.GetAllFlagsAsync();
        }
    }
}
