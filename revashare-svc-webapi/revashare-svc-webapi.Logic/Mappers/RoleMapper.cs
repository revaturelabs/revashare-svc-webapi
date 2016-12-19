using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Mappers
{
   public class RoleMapper
   {
      public static RoleDTO mapToRoleDTO(RoleDAO b)
      {
         var a = new RoleDTO();
         if (b != null)
         {
            a.Type = b.Type;
         }
         
         return a;
      }

      public static RoleDAO mapToRoleDAO(RoleDTO b)
      {
         var a = new RoleDAO();
         if(b!=null)
         {
            a.Type = b.Type;
         }
         
         return a;
      }
   }
}
