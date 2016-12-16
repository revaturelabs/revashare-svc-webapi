using revashare_svc_webapi.Logic.Model;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Interfaces
{
   public interface IRider
   {
      #region Apartment
      List<ApartmentDTO> getApartments();
      ApartmentDTO getApartmentByName(string name);
      #endregion

      #region Flag
      bool fileComplaintAboutDriver(FlagDTO flag);
      #endregion

      #region Rides
      List<RideDTO> getAvailableRides(string startLocation);
      List<RideDTO> getRides();
      int getAvailableSeatsInRide(RideDTO ride);

      RideDTO getCurrentSelectedRide(RideDTO ride);

      #endregion

      #region RideRider
      bool addRiderToRide(RideDTO ride, UserDTO rider);
      bool removeRiderFromRide(UserDTO user, RideDTO ride);
      List<RideRiderDTO> getRideRidersByUser(UserDTO user);
      List<RideRiderDTO> getRideRiders();
      List<UserDTO> GetRidersByRide(RideDTO ride);
      int getOccupiedSeatsByRide(RideDTO ride);

      #endregion

      #region User
      List<UserDTO> getUsers();
      bool modifyUserInfo(UserDTO user);
      #endregion      

      #region Vehicle
      List<VehicleDTO> getVehicles();
      VehicleDTO getVehicleByOwner(UserDTO user);
      #endregion

      //bool modifyCurrentSelectedRide(UserDTO user, RideDTO ride);
      bool requestToBeDriver(DriverEnrollDTO user);
      //bool modifyRiderInfo(UserDTO user);

   }
}
