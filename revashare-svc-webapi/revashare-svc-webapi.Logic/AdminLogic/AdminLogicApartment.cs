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
        public bool AddApartment(ApartmentDTO apt)
        {
            return sc.InsertApartment(ApartmentMapper.mapToApartmentDAO(apt));
        }

        public ApartmentDTO GetApartment(string name)
        {
            return ApartmentMapper.mapToApartmentDTO(sc.getApartmentByName(name));
        }

        public List<ApartmentDTO> GetApartments()
        {
            List<ApartmentDTO> apartments = new List<ApartmentDTO>();

            foreach (var apt in sc.GetApartments())
            {
                apartments.Add(ApartmentMapper.mapToApartmentDTO(apt));
            }

            return apartments;
        }

        public bool UpdateApartment(ApartmentDTO apt)
        {
            return sc.UpdateApartment(ApartmentMapper.mapToApartmentDAO(apt));
        }

        public bool RemoveApartment(ApartmentDTO apt)
        {
            return sc.DeleteApartment(ApartmentMapper.mapToApartmentDAO(apt));
        }
    }
}
