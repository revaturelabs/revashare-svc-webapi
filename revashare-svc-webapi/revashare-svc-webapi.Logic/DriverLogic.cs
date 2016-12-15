using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using revashare_svc_webapi.Logic.Mappers;

namespace revashare_svc_webapi.Logic {
  public class DriverLogic : IDriverRepository {
    private RevaShareDataServiceClient svc = new RevaShareDataServiceClient();

    public bool UpdateVehicleInfo(VehicleDTO vehicle) {
      try {
        return svc.UpdateVehicle(VehicleMapper.mapToVehicleDAO(vehicle));
      }
      catch (Exception) {
        return false;
      }
    }

    public bool ReportRider(FlagDTO flag) {
      try {
        return true;
      }
      catch (Exception) {
        return false;
      }
    }

    public bool SetAvailability() {
      try {
        return true;
      }
      catch (Exception) {
        return false;
      }
    }

    public bool ModifyDriverProfile(UserDTO driverToUpdate) {
      try {
        return true;
      }
      catch (Exception) {
        return false;
      }
    }

    public bool DeleteDriver(UserDTO driverToRemove) {
      try {
        return true;
      }
      catch (Exception) {
        return false;
      }
    }


    public bool ScheduleRide(RideDTO ride) {
      try {
        return svc.AddRide(RideMapper.mapToRideDAO(ride));
      }
      catch (Exception) {
        return false;
      }
    }

    public bool CancelRide(RideDTO ride) {
      try {
        return svc.DeleteRide(RideMapper.mapToRideDAO(ride).RideID.ToString());
      }
      catch (Exception) {
        return false;
      }
    }

    public bool AddVehicle(VehicleDTO vehicle) {
      try {
        return svc.AddVehicle(VehicleMapper.mapToVehicleDAO(vehicle));
      }
      catch (Exception) {
        return false;
      }
    }

    public bool InsertDriver(UserDTO driverToAdd) {
      try {
        return true;
      }
      catch (Exception) {
        return false;
      }
    }

    public List<UserDTO> RequestDrivers() {
      try {
        return new List<UserDTO>();
      }
      catch (Exception) {
        return null;
      }
    }
  }
}
