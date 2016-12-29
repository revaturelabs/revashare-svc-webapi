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
        
        public override bool AddVehicle(VehicleDTO vehicle)
        {
            return logic.AddVehicle(vehicle);
        }

        public override bool UpdateVehicleInfo(VehicleDTO vehicle)
        {
            return logic.UpdateVehicleInfo(vehicle);
        }

        public override bool ReportRider(FlagDTO flag)
        {
            return logic.ReportRider(flag);
        }

        public override bool SetAvailability(RideDTO ride)
        {
            return logic.SetAvailability(ride);
        }

        public override bool UpdateDriverProfile(UserDTO driver)
        {
            return logic.UpdateDriverProfile(driver);
        }

        public override bool ScheduleRide(RideDTO ride)
        {
            return logic.ScheduleRide(ride);
        }

        public override bool CancelRide(RideDTO ride)
        {
            return logic.CancelRide(ride);
        }

        public override bool AcceptPassenger(RideRiderDTO rider)
        {
            return logic.AcceptPassenger(rider);
        }

    }

}