using Newtonsoft.Json;
using revashare_svc_webapi.Logic.Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace revashare_svc_webapi.Client.Models.OwinModels
{
    public class UserFactory
    {

        private static UserFactory _factory = null;
        private static string USER_TYPE = "Unassigned";
        private static string RIDER_TYPE = "Rider";
        private static string REQUEST_DRIVER = "RequestDriver";
        private static string DRIVER_TYPE = "Driver";
        private static string ADMIN_TYPE = "Admin";

        public static UserFactory getFactory()
        {
            if (_factory == null)
            {
                _factory = new UserFactory();
            }
            return _factory;
        }

        public User getUser(Microsoft.Owin.IOwinContext context)
        {

            ClaimsPrincipal principal = context.Authentication.User;

            var claims = new List<Claim>(principal.FindAll(ClaimTypes.Role));

            List<string> roles = claims.ConvertAll(x => x.Value);


            if (claims.Count == 0)
            {
                return null;
            }

            if (roles.Contains(ADMIN_TYPE))
            {
                return new Admin(principal);
            }
            else if (roles.Contains(DRIVER_TYPE))
            {
                return new Driver(principal);
            }
            else if (roles.Contains(REQUEST_DRIVER))
            {
                return new Rider(principal);
            }
            else if (roles.Contains(RIDER_TYPE))
            {
                return new Rider(principal);
            }
            else if (roles.Contains(USER_TYPE))
            {
                return new User(principal);
            }
            else
            {
                return null;
            }

          
        }

    }
}