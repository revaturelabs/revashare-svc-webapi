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

    public VehicleDTO ViewVehicleInfo(UserDTO driver) {
      try {
        return null;
      }
      catch (Exception) {
        return null;
      }
    }

        public bool AddVehicle(VehicleDTO vehicle)
        {
            try
            {
                return svc.AddVehicle(VehicleMapper.mapToVehicleDAO(vehicle));
            }
            catch
            {
                return false;
            }
        }
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
        return svc.CreateFlag(FlagMapper.mapToFlagDAO(flag));
      }
      catch (Exception) {
        return false;
      }
    }

    public bool SetAvailability(RideDTO ride) {
      try {
        return svc.UpdateRide(RideMapper.mapToRideDAO(ride));
      }
      catch (Exception) {
        return false;
      }
    }

    public bool UpdateDriverProfile(UserDTO driver) {
      try {
        return svc.UpdateUser(UserMapper.mapToUserDAO(driver));
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
        return svc.DeleteRide(RideMapper.mapToRideDAO(ride));
      }
      catch (Exception) {
        return false;
      }
    }

    public List<SeatDTO> ViewPassengers() {
      try {
        return null;
      }
      catch (Exception) {
        return null;
      }
    }

    public bool AcceptPassenger(RideRiderDTO rider) {
      try {
        return svc.Accept(RideRiderMapper.mapToRideRiderDAO(rider));
      }
      catch (Exception) {
        return false;
      }
    }
  }
}
