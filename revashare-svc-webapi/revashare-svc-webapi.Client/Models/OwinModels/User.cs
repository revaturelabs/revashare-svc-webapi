using Newtonsoft.Json;
using revashare_svc_webapi.Logic.Model;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace revashare_svc_webapi.Client.Models.OwinModels
{

    public class MissingPermission: Exception
    {

    }

    public class User : ClaimsPrincipal
    {

        protected UserDTO userDetails;

        public string userName
        {
            get
            {
                return this.FindFirst(ClaimTypes.Name).Value;
            }
        }


        public User(ClaimsPrincipal principal) : base(principal)
        {
            string userJson = principal.FindFirst(ClaimTypes.UserData).Value;
            this.userDetails = JsonConvert.DeserializeObject<UserDTO>(userJson);
        }


        public UserDTO getUserDetails()
        {
            return this.userDetails;
        }


        public virtual bool isRider()
        {
            return false;
        }

        public virtual bool isDriver()
        {
            return false;
        }


        #region rider methods

        public virtual bool requestToBeDriver(DriverEnrollDTO enroll)
        {
            throw new MissingPermission();
        }

        public virtual List<ApartmentDTO> getApartments()
        {
            throw new MissingPermission();
        }

        public virtual ApartmentDTO getApartmentByName(string name)
        {
            throw new MissingPermission();
        }

        public virtual bool fileComplaintAboutDriver(FlagDTO flag)
        {
            throw new MissingPermission();
        }

        public virtual List<RideDTO> getAvailableRides(string startLocation)
        {
            throw new MissingPermission();
        }

        public virtual List<RideDTO> getRides()
        {
            throw new MissingPermission();
        }

        public virtual int getAvailableSeatsInRide(RideDTO ride)
        {
            throw new MissingPermission();
        }

        public virtual RideDTO getCurrentSelectedRide(RideDTO ride)
        {
            throw new MissingPermission();
        }

        public virtual bool addRiderToRide(RideDTO ride, UserDTO rider)
        {
            throw new MissingPermission();
        }

        public virtual bool removeRiderFromRide(UserDTO rider, RideDTO ride)
        {
            throw new MissingPermission();
        }

        public virtual List<RideRiderDTO> getRideRidersByUser(UserDTO rider)
        {
            throw new MissingPermission();
        }

        public virtual List<RideRiderDTO> getRideRiders()
        {
            throw new MissingPermission();
        }

        public virtual List<UserDTO> GetRidersByRide(RideDTO ride)
        {
            throw new MissingPermission();
        }

        public virtual int getOccupiedSeatsByRide(RideDTO ride)
        {
            throw new MissingPermission();
        }

        public virtual List<UserDTO> getUsers()
        {
            throw new MissingPermission();
        }

        public virtual bool modifyUserInfo(UserDTO user)
        {
            throw new MissingPermission();
        }

        public virtual List<VehicleDTO> getVehicles()
        {
            throw new MissingPermission();
        }

        public virtual VehicleDTO getVehicleByOwner(UserDTO owner)
        {
            throw new MissingPermission();
        }
        #endregion

        #region driver methods 
        public virtual VehicleDTO ViewVehicleInfo(string driver)
        {
            throw new MissingPermission();
        }

        public virtual bool AddVehicle(VehicleDTO vehicle)
        {
            throw new MissingPermission();
        }

        public virtual bool UpdateVehicleInfo(VehicleDTO vehicle)
        {
            throw new MissingPermission();
        }

        public virtual bool ReportRider(FlagDTO flag)
        {
            throw new MissingPermission();
        }

        public virtual bool SetAvailability(RideDTO ride)
        {
            throw new MissingPermission();
        }

        public virtual bool UpdateDriverProfile(UserDTO driver)
        {
            throw new MissingPermission();
        }

        public virtual bool ScheduleRide(RideDTO ride)
        {
            throw new MissingPermission();
        }

        public virtual RideDTO getSingleRide(RideDTO ride)
        {
            throw new MissingPermission();
        }

        public virtual bool CancelRide(RideDTO ride)
        {
            throw new MissingPermission();
        }

        public virtual List<UserDTO> ViewPassengers(RideDTO ride)
        {
            throw new MissingPermission();
        }

        public virtual bool AcceptPassenger(RideRiderDTO rider)
        {
            throw new MissingPermission();
        }

        #endregion

        #region admin methods

        public virtual bool InsertAdmin(UserDTO adminToAdd)
        {
            throw new MissingPermission();
        }

        public virtual List<UserDTO> RequestAdmins()
        {
            throw new MissingPermission();
        }

        public virtual UserDTO RequestAdmin(string UserName)
        {
            throw new MissingPermission();
        }

        public virtual bool ModifyAdmin(UserDTO adminToUpdate)
        {
            throw new MissingPermission();
        }

        public virtual bool DeleteAdmin(string UserName)
        {
            throw new MissingPermission();
        }

        public virtual bool ApproveUser(UserDTO userToApprove)
        {
            throw new MissingPermission();
        }

        public virtual bool ApproveDriver(UserDTO driverToApprove)
        {
            throw new MissingPermission();
        }

        public virtual List<UserDTO> GetPendingRiders()
        {
            throw new MissingPermission();
        }

        public virtual List<UserDTO> GetPendingDrivers()
        {
            throw new MissingPermission();
        }

        public virtual UserDTO RequestDriver(string UserName)
        {
            throw new MissingPermission();
        }

        public virtual List<UserDTO> RequestDrivers()
        {
            throw new MissingPermission();
        }

        public virtual bool ModifyDriver(UserDTO driverToUpdate)
        {
            throw new MissingPermission();
        }

        public virtual bool DeleteDriver(UserDTO driverToRemove)
        {
            throw new MissingPermission();
        }

        public virtual List<FlagDTO> GetUserReports()
        {
            throw new MissingPermission();
        }

        public virtual bool RemoveReport(FlagDTO reportToRemove)
        {
            throw new MissingPermission();
        }

        public virtual bool RemoveDriverPrivileges(FlagDTO reportForUser)
        {
            throw new MissingPermission();
        }

        public virtual UserDTO RequestRider(string UserName)
        {
            throw new MissingPermission();
        }

        public virtual List<UserDTO> RequestRiders()
        {
            throw new MissingPermission();
        }

        public virtual bool ModifyRider(UserDTO riderToUpdate)
        {
            throw new MissingPermission();
        }

        public virtual bool DeleteRider(UserDTO riderToRemove)
        {
            throw new MissingPermission();
        }

        #endregion



        }

}