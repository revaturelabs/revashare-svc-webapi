using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.Mappers;
using revashare_svc_webapi.Logic.Models;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic
{
    public class UserLogic
    {

        private static UserLogic logic = null;
        private IServiceClient client = null;

        private UserLogic()
        {
            
        }

        public static UserLogic getInstance()
        {
            if (logic == null)
            {
                logic = new UserLogic();
            }

            return logic;

        }


        public bool registerUser(UserDTO user, string password)
        {
            UserDAO userDao = UserMapper.mapToUserDAO(user);
            return client.Register(userDao, user.UserName, password);
        }


        public UserDTO login(string userName, string password)
        {
            UserDAO user = client.Login(userName, password);
            return UserMapper.mapToUserDTO(user);
        }

    }
}
