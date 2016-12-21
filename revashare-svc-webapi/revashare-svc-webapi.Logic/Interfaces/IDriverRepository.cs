using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Interfaces {
  public interface IDriverRepository {
    VehicleDTO ViewVehicleInfo(string driver);

        RideDTO getSingleRide(RideDTO ride);
    bool UpdateVehicleInfo(VehicleDTO vehicle);

    bool ReportRider(FlagDTO flag);

    bool SetAvailability(RideDTO ride);

    bool UpdateDriverProfile(UserDTO driver);

    bool ScheduleRide(RideDTO ride);

    bool CancelRide(RideDTO ride);

    List<UserDTO> ViewPassengers(RideDTO ride);

    bool AcceptPassenger(RideRiderDTO rider);
        bool AddVehicle(VehicleDTO vehicle);
    }
}
