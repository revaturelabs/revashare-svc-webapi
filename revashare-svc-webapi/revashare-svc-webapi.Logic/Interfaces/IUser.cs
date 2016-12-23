using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Interfaces
{
    public interface IUser
    {
        UserDTO GetUser(string UserName);
        ApartmentDTO GetApartment(string name);
        List<ApartmentDTO> GetApartments();
        List<RideDTO> GetRidesByApartment(string name);
        List<RideDTO> GetMorningRidesByApartment(string name);
        List<RideDTO> GetEveningRidesByApartment(string name);
    }
}
