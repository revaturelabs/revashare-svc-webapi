using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Mappers;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.UserLogic
{
    public partial class UserLogic : IUser
    {
        public List<RideDTO> GetRidesByApartment(string name)
        {
            List<RideDTO> rides = new List<RideDTO>();

            foreach (var ride in sc.GetRidesByApartment(name))
            {
                rides.Add(RideMapper.mapToRideDTO(ride));
            }

            return rides;
        }

        public List<RideDTO> GetMorningRidesByApartment(string name)
        {
            List<RideDTO> rides = new List<RideDTO>();

            foreach (var ride in sc.GetMorningRidesByApartment(name))
            {
                rides.Add(RideMapper.mapToRideDTO(ride));
            }

            return rides;
        }

        public List<RideDTO> GetEveningRidesByApartment(string name)
        {
            List<RideDTO> rides = new List<RideDTO>();

            foreach (var ride in sc.GetEveningRidesByApartment(name))
            {
                rides.Add(RideMapper.mapToRideDTO(ride));
            }

            return rides;
        }
    }
}
