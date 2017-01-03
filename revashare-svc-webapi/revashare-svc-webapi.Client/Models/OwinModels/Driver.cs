using revashare_svc_webapi.Logic;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace revashare_svc_webapi.Client.Models.OwinModels
{
    public class Driver : Rider
    {

        private IDriverRepository logic;

        public Driver(ClaimsPrincipal principal) : base(principal)
        {
            this.logic = new DriverLogic();
        }

        public override bool isRider()
        {
            return true;
        }

        public override bool isDriver()
        {
            return true;
        }

        public override VehicleDTO ViewVehicleInfo()
        {
            return logic.ViewVehicleInfo(this.userDetails.UserName);
        }

        public override bool AddVehicle(VehicleDTO vehicle)
        {
            if (logic.ViewVehicleInfo(this.userDetails.UserName) == null)
            {
                vehicle.Owner = this.userDetails;
                return logic.AddVehicle(vehicle);
            }
            else
            {
                return false;
            }
        }

        public override bool UpdateVehicleInfo(VehicleDTO vehicle)
        {
            if (logic.ViewVehicleInfo(this.userDetails.UserName) == null)
            {
                return false;
            }
            else
            {
                return logic.UpdateVehicleInfo(vehicle);
            }
        }

        public override bool ReportRider(FlagDTO flag)
        {
            flag.Driver = this.userDetails;
            return logic.ReportRider(flag);
        }

        public override bool SetAvailability(RideDTO ride)
        {
            return logic.SetAvailability(ride);
        }

        public override bool ScheduleRide(RideDTO ride)
        {

            VehicleDTO driverVehicle = this.logic.ViewVehicleInfo(this.userDetails.UserName);

            if (this.userDetails.Equals(driverVehicle.Owner))
            {
                ride.Vehicle = driverVehicle;

                return logic.ScheduleRide(ride);
            }
            else
            {
                throw new UnauthorizedAccessException();
            }

        }

        public override bool CancelRide(RideDTO ride)
        {

            if (ride.Vehicle.Equals(this.logic.ViewVehicleInfo(this.userDetails.UserName)))
            {
                return logic.CancelRide(ride);
            }
            else
            {
                throw new UnauthorizedAccessException();
            }

            
        }

        public override bool AcceptPassenger(RideRiderDTO rideRider)
        {

            if (rideRider.Ride.Vehicle.Owner.Equals(this.userDetails))
            {
                return logic.AcceptPassenger(rideRider);
            }
            else
            {
                throw new UnauthorizedAccessException();
            }

            
        }

    }

}