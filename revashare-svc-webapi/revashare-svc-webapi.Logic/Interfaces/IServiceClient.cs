using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Interfaces
{
   public interface IServiceClient
   {
      bool DeleteApartment(ApartmentDAO apartment);
      List<ApartmentDAO> GetApartments();
      bool InsertApartment(ApartmentDAO apartment);
      bool UpdateApartment(ApartmentDAO apartment);
      ApartmentDAO getApartmentByName(string name);

      bool deleteFlag(FlagDAO flag);
      List<FlagDAO> GetFlags();
      bool InsertFlag(FlagDAO flag);
      bool UpdateFlag(FlagDAO flag);
      FlagDAO GetFlagsById(FlagDAO flag);

      List<RideDAO> GetRides();
      bool InsertRide(RideDAO ride);
      bool UpdateRide(RideDAO ride);
      bool DeleteRide(RideDAO ride);
      List<RideDAO> getRidesByLocation();
      int getAvailableSeatsByRide(RideDAO ride);

      List<RideRidersDAO> GetRideRiders();
      bool InsertRideRider(UserDAO rider, RideDAO ride);
      bool UpdateRideRider(RideRidersDAO rideRider);
      bool DeleteRideRider(RideRidersDAO rr);
      bool Accept(RideRidersDAO rr);

      bool DeleteUser(UserDAO user);
      List<UserDAO> GetUsers();
      bool UpdateUser(UserDAO user);
      bool Login(string UserName, string Password);
      bool Register(UserDAO user, string UserName, string Password);
      bool UpdateUserRole(string UserName, string role);
      bool AproveDriver(string UserName);
      bool AproveUser(string UserName);
      List<UserDAO> PendingRegistrations();
      List<UserDAO> PendingDriverAprovals();

      bool DeleteVehicle(VehicleDAO v);
      List<VehicleDAO> GetVehicle();
      bool InsertVehicle(VehicleDAO v);
      bool UpdateVehicle(VehicleDAO v);

      bool RequestToBeDriver(UserDAO user);
   }
}