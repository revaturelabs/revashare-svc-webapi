using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Mappers
{
   public class FlagMapper
   {
      public static FlagDTO mapToFlagDTO(FlagDAO b)
      {
         var a = new FlagDTO();
         if (b.Driver != null)
         {
            a.Driver = UserMapper.mapToUserDTO(b.Driver);
         }
         a.Message = b.Message;
         if (b.Rider != null)
         {
            a.Rider = UserMapper.mapToUserDTO(b.Rider);
         }
         a.Type = b.Type;
         return a;
      }

      public static FlagDAO mapToFlagDAO(FlagDTO b)
      {
         var a = new FlagDAO();
         if (b.Driver != null)
         {
            a.Driver = UserMapper.mapToUserDAO(b.Driver);
         }
         a.Message = b.Message;
         if (b.Rider != null)
         {
            a.Rider = UserMapper.mapToUserDAO(b.Rider);
         }
         a.Type = b.Type;
         return a;
      }
   }
}