using revashare_svc_webapi.Logic.ModelDTO;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Mappers
{
   public class ApartmentMapper
   {
      public static ApartmentDTO mapToApartmentDTO(ApartmentDAO b)
      {
         var a = new ApartmentDTO();
         a.Latitude = b.Latitude;
         a.Longitude = b.Longitude;
         a.Name = b.Name;

         return a;
      }

      public static ApartmentDAO mapToApartmentDAO(ApartmentDTO b)
      {
         var a = new ApartmentDAO();
         a.Latitude = b.Latitude;
         a.Longitude = b.Longitude;
         a.Name = b.Name;

         return a;
      }
      */
   }
}
