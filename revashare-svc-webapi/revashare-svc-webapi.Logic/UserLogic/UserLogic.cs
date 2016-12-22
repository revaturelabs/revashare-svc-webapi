using revashare_svc_webapi.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.Mappers;

namespace revashare_svc_webapi.Logic.UserLogic
{
    public partial class UserLogic : IUser
    {
        private IServiceClient sc;
        public UserLogic(IServiceClient client)
        {
            sc = client;
        }

        public UserDTO GetUser(string UserName)
        {
            return UserMapper.mapToUserDTO(sc.GetUser(UserName));
        }
    }
}
