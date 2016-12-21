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
        public UserDTO RequestDriver(string UserName)
        {
            return UserMapper.mapToUserDTO(sc.GetUser(UserName));
        }

        public List<UserDTO> RequestDrivers()
        {
            throw new NotImplementedException();
        }

        public bool ModifyDriver(UserDTO driverToUpdate)
        {
            var apartments = sc.GetApartments();
            ApartmentDAO newApartment = null;

            foreach (var apartment in apartments)
            {
                if (apartment.Name == driverToUpdate.Apartment.Name)
                {
                    newApartment = apartment;
                }
            }

            if (newApartment != null)
            {
                var updateUser = UserMapper.mapToUserDAO(driverToUpdate);

                return sc.ModifyAdmin(updateUser);
            }
            else
            {
                return false;
            }
        }

        public bool DeleteDriver(UserDTO driverToRemove)
        {
            return sc.DeleteUser(UserMapper.mapToUserDAO(driverToRemove));
        }
    }
}
