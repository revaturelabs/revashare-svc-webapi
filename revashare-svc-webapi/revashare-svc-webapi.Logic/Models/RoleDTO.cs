using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Models
{
   public class RoleDTO
   {

        public static string USER_TYPE = "Unassigned";
        public static string RIDER_TYPE = "Rider";
        public static string DRIVER_TYPE = "Driver";
        public static string PENDING_DRIVER_TYPE = "RequestDriver";
        public static string ADMIN_TYPE = "Admin";

        public string Type { get; set; }
   }
}
