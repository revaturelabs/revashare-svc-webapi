using Newtonsoft.Json;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.ServiceClient;
using revashare_svc_webapi.Logic.UserLogic;
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
        private UserLogic logic;

        public string userName
        {
            get
            {
                return userDetails.UserName;
                //return this.FindFirst(ClaimTypes.Name).Value;
            }
        }


        public User(ClaimsPrincipal principal) : base(principal)
        {
            string userJson = principal.FindFirst(ClaimTypes.UserData).Value;
            this.userDetails = JsonConvert.DeserializeObject<UserDTO>(userJson);
            this.logic = new UserLogic(new ServiceClient());
        }

        public UserDTO getProfile()
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


        public virtual bool updateProfile(UserDTO user)
        {

            user.UserName = this.userDetails.UserName;
            user.Roles = this.userDetails.Roles;

            return logic.updateUser(user);
        }


        public virtual bool updateProfileApartment(ApartmentDTO apartment)
        {
            
            UserDTO newProfile = new UserDTO();
            newProfile.Apartment = apartment;
            newProfile.ApartmentId = this.userDetails.ApartmentId;
            newProfile.Email = this.userDetails.Email;
            newProfile.Name = this.userDetails.Name;
            newProfile.PhoneNumber = this.userDetails.PhoneNumber;
            newProfile.Roles = this.userDetails.Roles;
            newProfile.UserName = this.userDetails.UserName;

            bool success = this.logic.updateUser(newProfile);
            
            return success;

        }
        

        #region rider methods

        public virtual bool requestToBeDriver(VehicleDTO car)
        {
            throw new MissingPermission();
        }

        public virtual List<ApartmentDTO> getApartments()
        {
            throw new MissingPermission();
        }
        
        public virtual bool fileComplaintAboutDriver(FlagDTO flag)
        {
            throw new MissingPermission();
        }
        
        public virtual List<RideDTO> getRides()
        {
            throw new MissingPermission();
        }

        public virtual List<RideDTO> getAvailableRides()
        {
            throw new MissingPermission();
        }

        public virtual List<RideDTO> getScheduledRides()
        {
            throw new MissingPermission();
        }

        public virtual bool bookRide(RideDTO ride)
        {
            throw new MissingPermission();
        }

        public virtual bool unBookRide(RideDTO ride)
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
        public virtual VehicleDTO ViewVehicleInfo()
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

        public virtual bool CancelRide(RideDTO ride)
        {
            throw new MissingPermission();
        }
        
        public virtual bool AcceptPassenger(RideRiderDTO rider)
        {
            throw new MissingPermission();
        }

        #endregion

        #region admin methods

        public virtual bool InsertAdmin(UserDTO adminToAdd, string password)
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

        public virtual List<FlagDTO> GetUserReports(UserDTO user)
        {
            throw new MissingPermission();
        }

        public virtual bool RemoveReport(FlagDTO reportToRemove)
        {
            throw new MissingPermission();
        }

        public virtual bool RemoveDriverPrivileges(string UserName)
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