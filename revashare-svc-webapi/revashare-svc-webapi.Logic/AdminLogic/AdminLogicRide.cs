using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Mappers;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.AdminLogic
{
    public partial class AdminLogic : IAdmin
    {
        public bool InsertRide(RideDTO ride)
        {
            return sc.InsertRide(RideMapper.mapToRideDAO(ride));
        }

        public RideDTO GetRide(RideDTO ride)
        {
            var rides = sc.GetRidesByApartment(ride.Vehicle.Owner.Apartment.Name);
            return Mappers.RideMapper.mapToRideDTO(rides.Where(x => x.Vehicle.Owner.UserName == ride.Vehicle.Owner.UserName
                                                                 && x.IsAmRide == ride.IsAMRide
                                                                 && x.StartOfWeek == ride.StartOfWeekDate).FirstOrDefault());
        }

        public List<RideDTO> GetRides()
        {
            List<RideDTO> rides = new List<RideDTO>();

            foreach (var ride in sc.GetRides())
            {
                rides.Add(RideMapper.mapToRideDTO(ride));
            }

            return rides;
        }

        public bool ModifyRide(RideDTO ride)
        {
            return sc.UpdateRide(RideMapper.mapToRideDAO(ride));
        }

        public bool DeleteRide(RideDTO ride)
        {
            return sc.DeleteRide(RideMapper.mapToRideDAO(ride));
        }

    }
}
