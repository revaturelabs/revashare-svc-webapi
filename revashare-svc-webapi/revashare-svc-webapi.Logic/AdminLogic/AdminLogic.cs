using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Mappers;
using revashare_svc_webapi.Logic.Models;
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

        public bool InsertAdmin(UserDTO adminToAdd)
        {
            throw new NotImplementedException();
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
            var updateUser = UserMapper.mapToUserDAO(adminToUpdate);

            return sc.ModifyAdmin(updateUser);
        }
        public bool DeleteAdmin(string UserName)
        {
            return sc.DeleteAdmin(UserName);
        }
    }
}
