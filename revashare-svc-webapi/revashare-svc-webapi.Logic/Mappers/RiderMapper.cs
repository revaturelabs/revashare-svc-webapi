using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Mappers
{
   public class RiderMapper
   {
      public static RiderDTO mapToRiderDTO(RiderDAO b)
      {
         var a = new RiderDTO();
         a.UserName = b.UserName;
      }

      public static RiderDAO mapToRiderDAO(RiderDTO b)
      {
         var a = new RiderDAO();
         a.UserName = b.UserName;
      }
   }
}
