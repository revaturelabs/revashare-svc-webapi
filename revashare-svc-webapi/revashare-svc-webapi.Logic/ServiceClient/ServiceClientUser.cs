using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.RevaShareServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revashare_svc_webapi.Logic.ServiceClient
{
    public partial class ServiceClient : IServiceClient
    {
        public bool DeleteUser(UserDAO user)
        {
            return rs.DeleteUser(user.Name);
        }

        public UserDAO GetUser(string UserName)
        {
            return rs.GetUserByUsername(UserName);
        }

        public List<UserDAO> GetRiders()
        {
            return rs.GetRiders().ToList();
        }
        public List<UserDAO> GetDrivers()
        {
            return rs.GetDrivers().ToList();
        }
        public bool UpdateUser(UserDAO user)
        {
            return rs.UpdateUser(user);
        }
        public bool RequestToBeDriver(string user)
        {
            return rs.RequestToBeDriver(user);
        }
        public UserDAO Login(string UserName, string Password)
        {
            if (rs.Login(UserName, Password) != null)
            {
                return null;
            }
            else
            {
                return null;
            }
        }
        public bool Register(UserDAO user, string UserName, string Password)
        {
            return rs.RegisterUser(user, UserName, Password);
        }
    }
}
