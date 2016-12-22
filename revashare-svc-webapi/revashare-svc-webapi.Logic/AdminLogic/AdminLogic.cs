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
        private IServiceClient sc;
        public AdminLogic(IServiceClient client)
        {
            sc = client;
        }

        public bool InsertAdmin(UserDTO adminToAdd, string UserName, string Password)
        {
            return sc.InsertAdmin(UserMapper.mapToUserDAO(adminToAdd), UserName, Password);
        }

        public List<UserDTO> RequestAdmins()
        {
            List<UserDTO> requestedAdmins = new List<UserDTO>();

            foreach (var admin in sc.RequestAdmins())
            {
                requestedAdmins.Add(UserMapper.mapToUserDTO(admin));
            }

            return requestedAdmins;
        }

        public UserDTO RequestAdmin(string UserName)
        {
            return UserMapper.mapToUserDTO(sc.RequestAdmin(UserName));
        }

        public bool ModifyAdmin(UserDTO adminToUpdate)
        {
            var apartments = sc.GetApartments();
            ApartmentDAO newApartment = null;

            foreach (var apartment in apartments)
            {
                if(apartment.Name == adminToUpdate.Apartment.Name)
                {
                    newApartment = apartment;
                }
            }

            if (newApartment != null)
            {
                var updateUser = UserMapper.mapToUserDAO(adminToUpdate);

                return sc.ModifyAdmin(updateUser);
            }
            else
            {
                return false;
            }
        }
        public bool DeleteAdmin(string UserName)
        {
            return sc.DeleteAdmin(UserName);
        }
    }
}
