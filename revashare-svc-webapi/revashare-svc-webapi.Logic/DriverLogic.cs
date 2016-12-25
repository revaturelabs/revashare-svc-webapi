using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using revashare_svc_webapi.Logic.Mappers;

namespace revashare_svc_webapi.Logic
{
    public class DriverLogic : IDriverRepository
    {
        private RevaShareDataServiceClient svc = new RevaShareDataServiceClient();

        public VehicleDTO ViewVehicleInfo(string driver)
        {
            try
            {
                var vehicles = svc.GetVehicles();
                foreach (var item in vehicles)
                {
                    if (item.Owner.UserName == driver)
                    {
                        return Mappers.VehicleMapper.mapToVehicleDTO(item);
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool AddVehicle(VehicleDTO vehicle)
        {
            VehicleDAO something = Mappers.VehicleMapper.mapToVehicleDAO(vehicle);
            return svc.AddVehicle(VehicleMapper.mapToVehicleDAO(vehicle));
        }
        public bool UpdateVehicleInfo(VehicleDTO vehicle)
        {
            try
            {
                return svc.UpdateVehicle(VehicleMapper.mapToVehicleDAO(vehicle));
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ReportRider(FlagDTO flag)
        {
            try
            {
                return svc.CreateFlag(FlagMapper.mapToFlagDAO(flag));
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SetAvailability(RideDTO ride)
        {
            try
            {
                return svc.UpdateRide(RideMapper.mapToRideDAO(ride));
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateDriverProfile(UserDTO driver)
        {
            try
            {
                return svc.UpdateUser(UserMapper.mapToUserDAO(driver));
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool ScheduleRide(RideDTO ride)
        {
            try
            {
                return svc.AddRide(RideMapper.mapToRideDAO(ride));
            }
            catch (Exception)
            {
                return false;
            }
        }

        public RideDTO getSingleRide(RideDTO ride)
        {
            var location = svc.GetUserByUsername(ride.Vehicle.Owner.UserName);
            var rides = svc.ListRidesAtApartment(location.Apartment.Name);
            return Mappers.RideMapper.mapToRideDTO(rides.Where(x => x.Vehicle.Owner.UserName == ride.Vehicle.Owner.UserName
                                            && x.IsAmRide == ride.IsAMRide
                                            && x.StartOfWeek == ride.StartOfWeekDate).FirstOrDefault());
        }

        public bool CancelRide(RideDTO ride)
        {
            try
            {
                return svc.DeleteRide(RideMapper.mapToRideDAO(ride));
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<UserDTO> ViewPassengers(RideDTO ride)
        {
            try
            {
                List<UserDTO> members = new List<UserDTO>();
                ride = getSingleRide(ride);
                var riders = svc.getRidersInRide(Mappers.RideMapper.mapToRideDAO(ride));
                foreach (var item in riders)
                {
                    members.Add(Mappers.UserMapper.mapToUserDTO(item));
                }
                return members;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool AcceptPassenger(RideRiderDTO rideRider)
        {
            
            bool success = svc.AcceptRideRequest(Mappers.RideRiderMapper.mapToRideRiderDAO(rideRider));

            return success;

        }

        public bool RemovePassenger(RideRiderDTO rideRider)
        {
            return svc.DeleteRideRider(Mappers.RideRiderMapper.mapToRideRiderDAO(rideRider));

        }

    }
}
