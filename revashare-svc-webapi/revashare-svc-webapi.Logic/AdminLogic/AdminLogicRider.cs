using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Mappers;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.AdminLogic
{
    public partial class AdminLogic : IAdmin
    {
        public UserDTO RequestRider(string UserName)
        {
            return UserMapper.mapToUserDTO(sc.GetUserByUsername(UserName));
        }

        public List<UserDTO> RequestRiders()
        {
            throw new NotImplementedException();
        }

        public bool ModifyRider(UserDTO riderToUpdate)
        {
            var apartments = sc.GetApartments();
            ApartmentDAO newApartment = null;

            foreach (var apartment in apartments)
            {
                if (apartment.Name == riderToUpdate.Apartment.Name)
                {
                    newApartment = apartment;
                }
            }

            if (newApartment != null)
            {
                var updateUser = UserMapper.mapToUserDAO(riderToUpdate);

                return sc.ModifyAdmin(updateUser);
            }
            else
            {
                return false;
            }
        }

        public bool DeleteRider(UserDTO riderToRemove)
        {
            return sc.DeleteUser(UserMapper.mapToUserDAO(riderToRemove));
        }
    }
}
