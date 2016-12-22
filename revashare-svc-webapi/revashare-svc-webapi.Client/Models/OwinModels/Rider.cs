using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Claims;
using revashare_svc_webapi.Logic.RiderLogic;
using revashare_svc_webapi.Logic.ServiceClient;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.Model;

namespace revashare_svc_webapi.Client.Models.OwinModels
{
    public class Rider : User
    {

        RiderLogic logic;

        public Rider(ClaimsPrincipal principal) : base(principal)
        {
            this.logic = new RiderLogic(new ServiceClient());
        }

        public override bool isRider()
        {
            return true;
        }

        public override bool isDriver()
        {
            return false;
        }

        public override bool requestToBeDriver(DriverEnrollDTO enroll)
        {
            return logic.requestToBeDriver(enroll);
        }

        public override List<ApartmentDTO> getApartments()
        {
            return logic.getApartments();
        }

        public override ApartmentDTO getApartmentByName(string name)
        {
            return logic.getApartmentByName(name);
        }

        public override bool fileComplaintAboutDriver(FlagDTO flag)
        {
            return logic.fileComplaintAboutDriver(flag);
        }

        public override List<RideDTO> getAvailableRides(string startLocation)
        {
            return logic.getAvailableRides(startLocation);
        }

        public override List<RideDTO> getRides()
        {
            return logic.getRides();
        }

        public override int getAvailableSeatsInRide(RideDTO ride)
        {
            return logic.getAvailableSeatsInRide(ride);
        }

        public override RideDTO getCurrentSelectedRide(RideDTO ride)
        {
            return logic.getCurrentSelectedRide(ride);
        }

        public override bool addRiderToRide(RideDTO ride, UserDTO rider)
        {
            return logic.addRiderToRide(ride, rider);
        }

        public override bool removeRiderFromRide(UserDTO rider, RideDTO ride)
        {
            return logic.removeRiderFromRide(rider, ride);
        }

        public override List<RideRiderDTO> getRideRidersByUser(UserDTO rider)
        {
            return logic.getRideRidersByUser(rider);
        }

        public override List<RideRiderDTO> getRideRiders()
        {
            return logic.getRideRiders();
        }

        public override List<UserDTO> GetRidersByRide(RideDTO ride)
        {
            return logic.GetRidersByRide(ride);
        }

        public override int getOccupiedSeatsByRide(RideDTO ride)
        {
            return logic.getOccupiedSeatsByRide(ride);
        }

        









        }

}