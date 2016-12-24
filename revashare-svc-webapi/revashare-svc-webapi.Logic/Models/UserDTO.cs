using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.Models
{
    public class UserDTO : IEquatable<UserDTO>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public ApartmentDTO Apartment { get; set; }
        public string Email { get; set; }
        public int ApartmentId { get; set; }
        public List<RoleDTO> Roles { get; set; }
        public string UserName { get; set; }

        public bool Equals(UserDTO other)
        {
            return this.UserName.Equals(other.UserName);
        }

    }
}
