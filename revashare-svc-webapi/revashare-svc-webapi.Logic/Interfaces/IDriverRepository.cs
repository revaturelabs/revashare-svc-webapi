using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Interfaces {
  public interface IDriverRepository {
    bool UpdateVehicleInfo(VehicleDTO vehicle);

    bool ReportRider(FlagDTO flag);

    bool SetAvailability(RideDTO ride);

    bool UpdateDriverProfile(UserDTO driver);

    bool ScheduleRide(RideDTO ride);

    bool CancelRide(RideDTO ride);

    List<SeatDTO> ViewPassengers();

    bool AcceptPassenger(SeatDTO rider;
    }
}
