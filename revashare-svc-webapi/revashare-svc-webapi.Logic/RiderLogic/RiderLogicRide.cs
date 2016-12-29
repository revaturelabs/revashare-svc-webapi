using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.Models;

namespace revashare_svc_webapi.Logic.RiderLogic
{

    public partial class RiderLogic : IRider
    {
        public List<RideDTO> getAvailableRides(string startLocation)
        {
            return sc.getRidesByLocation(startLocation).ConvertAll(x => Mappers.RideMapper.mapToRideDTO(x));
        }
        public List<RideDTO> getRides()
        {
            return sc.GetRides().ConvertAll(x => Mappers.RideMapper.mapToRideDTO(x));
        }

        public List<UserDTO> getRiders()
        {
            return sc.GetRiders().ConvertAll(x => Mappers.UserMapper.mapToUserDTO(x));
        }

        public int getAvailableSeatsInRide(RideDTO ride)
        {
            return sc.getAvailableSeatsByRide(Mappers.RideMapper.mapToRideDAO(ride));
        }

        public RideDTO getCurrentSelectedRide(RideDTO ride)
        {
            return getRides().Where(m => m.Vehicle.LicensePlate.Equals(ride.Vehicle.LicensePlate)).FirstOrDefault();
        }


    }

}
