using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Claims;
using revashare_svc_webapi.Logic.RiderLogic;
using revashare_svc_webapi.Logic.ServiceClient;
using revashare_svc_webapi.Logic.Models;


namespace revashare_svc_webapi.Client.Models.OwinModels
{
    public class Rider : User
    {

        RiderLogic logic;

        public override List<RideRiderDTO> getRideRidersByUser(UserDTO rider)
        {
            return logic.getRideRidersByUser(rider);
        }
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

        public override bool requestToBeDriver(VehicleDTO car)
        {

            car.Owner = this.getProfile();

            return logic.requestToBeDriver(new DriverEnrollDTO()
            {
                User = this.userDetails,
                MyCar = car
            });
        }

        public override List<ApartmentDTO> getApartments()
        {
            return logic.getApartments();
        }

        public override bool fileComplaintAboutDriver(FlagDTO flag)
        {

            flag.Rider = this.getProfile();

            return logic.fileComplaintAboutDriver(flag);
        }

        public override List<RideDTO> getRides()
        {
            return logic.getRides();
        }

        public override List<RideDTO> getAvailableRides()
        {
            return logic.getRides().Where(x => x.Vehicle.Owner.Apartment.Equals(this.userDetails.Apartment)).ToList();
        }

        public override List<RideDTO> getScheduledRides()
        {
            var rideRiders = logic.getRideRidersByUser(this.userDetails);

            var rides = logic.getRides();

            return rides.Where(x => rideRiders.Any(y => y.Ride.Equals(x))).ToList();

        }

        public override bool bookRide(RideDTO ride)
        {
            return logic.addRiderToRide(ride, this.getProfile());
        }

        public override bool unBookRide(RideDTO ride)
        {
            return logic.removeRiderFromRide(new RideRiderDTO()
            {
                Ride = ride,
                Rider = this.getProfile()
            });
        }
        


    }

}