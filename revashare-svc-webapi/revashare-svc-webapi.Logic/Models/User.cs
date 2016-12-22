using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Models
{

   public class User
   {
      public string Name { get; set; }
      public string PhoneNumber { get; set; }
      public ApartmentDTO Apartment { get; set; }
      public string Email { get; set; }
      public VehicleDTO Vehicle { get; set; }
      public string AccountType { get; set; }
      
   }
}
