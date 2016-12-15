using revashare_svc_webapi.Logic.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Interfaces
{
   public class UserDTO
   {
      public string Name { get; set; }
      public string PhoneNumber { get; set; }      
      public ApartmentDTO Apartment { get; set; }
      public string Email { get; set; }
      public int ApartmentId { get; set; }

   }
}
