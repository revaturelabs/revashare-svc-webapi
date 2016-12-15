using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;

namespace revashare_svc_webapi.Logic {
  public class DriverLogic : IDriverRepository {
    public bool UpdateVehicleInfo(VehicleDTO vehicle) {
      throw new NotImplementedException();
    }

    public bool ReportRider(FlagDTO flag) {
      throw new NotImplementedException();
    }

    public bool SetAvailability() {
      throw new NotImplementedException();
    }

    #region Driver CRUD Methods
    public bool InsertDriver(UserDTO driverToAdd) {
      return true;
    }

    public List<UserDTO> RequestDrivers() {
      return new List<UserDTO>();
    }

    public bool ModifyDriver(UserDTO driverToUpdate) {
      return true;
    }

    public bool DeleteDriver(UserDTO driverToRemove) {
      return true;
    }
    #endregion

    public bool ScheduleRide(RideDTO ride) {
      throw new NotImplementedException();
    }

    public bool CancelRide(RideDTO ride) {
      throw new NotImplementedException();
    }

    public bool AddVehicle(VehicleDTO vehicle) {
      throw new NotImplementedException();
    }
  }
}
