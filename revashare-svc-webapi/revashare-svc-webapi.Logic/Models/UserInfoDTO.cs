using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Models
{
    public class UserInfoDTO
    {
        public string UserId { get; set; }

        public string ApartmentId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public UserDTO User { get; set; }

        public ApartmentDTO Apartment { get; set; }
   }
}
