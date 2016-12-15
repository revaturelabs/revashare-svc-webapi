﻿using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Interfaces {
  public interface IDriverRepository {
    bool UpdateVehicleInfo(VehicleDTO vehicle);

    bool ReportRider(FlagDTO flag);

    bool SetAvailability();

    bool ModifyDriverProfile(UserDTO driverToUpdate);

    }
}
