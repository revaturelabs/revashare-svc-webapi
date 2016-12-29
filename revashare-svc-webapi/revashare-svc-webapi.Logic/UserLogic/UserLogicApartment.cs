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
        public ApartmentDTO GetApartment(string name)
        {
            return ApartmentMapper.mapToApartmentDTO(sc.getApartmentByName(name));
        }

        public List<ApartmentDTO> GetApartments()
        {
            List<ApartmentDTO> apartments = new List<ApartmentDTO>();

            foreach (var apartment in sc.GetApartments())
            {
                apartments.Add(ApartmentMapper.mapToApartmentDTO(apartment));
            }

            return apartments;
        }
    }
}
