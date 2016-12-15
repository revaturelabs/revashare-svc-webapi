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

      bool DeleteUser(UserDAO user);
      List<UserDAO> GetUsers();
      bool InsertUser(UserDAO user);
      bool UpdateUser(UserDAO user);

      //bool deleteUserInfo(UserInfoDAO info);   
      //List<UserInfoDAO> GetUserInfos(); 
      //bool InsertUserInfo(UserInfoDAO info);
      //bool UpdateUserInfo(UserInfoDAO info);

      bool DeleteVehicle(VehicleDAO v);
      List<VehicleDAO> GetVehicle();
      bool InsertVehicle(VehicleDAO v);
      bool UpdateVehicle(VehicleDAO v);

   }
}
