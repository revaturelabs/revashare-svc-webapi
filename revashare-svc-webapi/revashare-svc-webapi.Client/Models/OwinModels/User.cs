using revashare_svc_webapi.Logic.Model;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace revashare_svc_webapi.Client.Models.OwinModels
{
    public class User : ClaimsPrincipal
    {



        public string userName
        {
            get
            {
                return this.FindFirst(ClaimTypes.Name).Value;
            }
        }


        public User(ClaimsPrincipal principal) : base(principal)
        {

        }


        public virtual bool isRider()
        {
            return false;
        }

        public virtual bool isDriver()
        {
            return false;
        }

        public virtual bool requestToBeDriver(DriverEnrollDTO enroll)
        {
            throw new NotImplementedException();
        }

        public virtual List<ApartmentDTO> getApartments()
        {
            throw new NotImplementedException();
        }

        public virtual ApartmentDTO getApartmentByName(string name)
        {
            throw new NotImplementedException();
        }

        public virtual bool fileComplaintAboutDriver(FlagDTO flag)
        {
            throw new NotImplementedException();
        }

        public virtual List<RideDTO> getAvailableRides(string startLocation)
        {
            throw new NotImplementedException();
        }

        public virtual List<RideDTO> getRides()
        {
            throw new NotImplementedException();
        }

        public virtual int getAvailableSeatsInRide(RideDTO ride)
        {
            throw new NotImplementedException();
        }

        public virtual RideDTO getCurrentSelectedRide(RideDTO ride)
        {
            throw new NotImplementedException();
        }

        public virtual bool addRiderToRide(RideDTO ride, UserDTO rider)
        {
            throw new NotImplementedException();
        }

        public virtual bool removeRiderFromRide(UserDTO rider, RideDTO ride)
        {
            throw new NotImplementedException();
        }

        public virtual List<RideRiderDTO> getRideRidersByUser(UserDTO rider)
        {
            throw new NotImplementedException();
        }

        public virtual List<RideRiderDTO> getRideRiders()
        {
            throw new NotImplementedException();
        }

        public virtual List<UserDTO> GetRidersByRide(RideDTO ride)
        {
            throw new NotImplementedException();
        }

        public virtual int getOccupiedSeatsByRide(RideDTO ride)
        {
            throw new NotImplementedException();
        }

        public virtual List<UserDTO> getUsers()
        {
            throw new NotImplementedException();
        }

        public virtual bool modifyUserInfo(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public virtual List<VehicleDTO> getVehicles()
        {
            throw new NotImplementedException();
        }

        public virtual VehicleDTO getVehicleByOwner(UserDTO owner)
        {
            throw new NotImplementedException();
        }











        }

}