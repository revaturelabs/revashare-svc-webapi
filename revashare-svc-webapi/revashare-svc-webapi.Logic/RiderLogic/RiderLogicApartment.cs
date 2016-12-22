using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.RiderLogic
{
   public partial class RiderLogic:IRider
   {
      public List<ApartmentDTO> getApartments()
      {
         var list = sc.GetApartments();
         var a = new List<ApartmentDTO>();
         foreach (var item in list)
         {
            a.Add(Mappers.ApartmentMapper.mapToApartmentDTO(item));
         }
         return a;
      }

      public ApartmentDTO getApartmentByName(string name)
      {
         return getApartments().Where(m => m.Name.Equals(name)).FirstOrDefault();
      }
   }
}
