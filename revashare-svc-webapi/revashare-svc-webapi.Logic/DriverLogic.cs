﻿using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;

namespace revashare_svc_webapi.Logic
{
    public class DriverLogic: IDriverRepository
    {
        public bool UpdateVehicleInfo(VehicleDTO vehicle)
        {
            throw new NotImplementedException();
        }

        public bool ReportRider(FlagDTO flag)
        {
            throw new NotImplementedException();
        }

        public bool SetAvailability()
        {
            throw new NotImplementedException();
        }

        public bool ModifyDriverProfile(UserDTO driverToUpdate)
        {
            return true;
        }

    }
}
