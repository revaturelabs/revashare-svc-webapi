
using System.Security.Claims;

namespace revashare_svc_webapi.Logic.Models.OwinModels
{

    public class UserFactory
    {

        private static UserFactory _factory = null;
        private static string USER_TYPE = "user";
        private static string RIDER_TYPE = "rider";
        private static string DRIVER_TYPE = "driver";

        public static UserFactory getFactory()
        {
            if (_factory == null)
            {
                _factory = new UserFactory();
            }
            return _factory;
        }

        public User getUser(ClaimsPrincipal principal)
        {

            string roleName = principal.FindFirst(ClaimTypes.Role).Value;

            if (roleName.Equals(USER_TYPE))
            {
                return new OwinModels.User(principal);
            }
            else if (roleName.Equals(RIDER_TYPE))
            {
                return new OwinModels.Rider(principal);
            }
            else if (roleName.Equals(DRIVER_TYPE))
            {
                return new OwinModels.Driver(principal);
            }
            else
            {
                return null;
            }
        }

    }


    public class User: ClaimsPrincipal
    {

        public string userName
        {
            get
            {
                return this.FindFirst(ClaimTypes.Name).Value;
            }
        }

        public User(ClaimsPrincipal principal): base(principal)
        {

        }

        public virtual bool isRider()
        {
            return false;
        }

        public virtual bool isDriver()
        {
            return false;
        }


    }

    public class Rider: User
    {
        public Rider(ClaimsPrincipal principal): base(principal)
        {

        }

        public override bool isRider()
        {
            return true;
        }

        public override bool isDriver()
        {
            return false;
        }

    }

    public class Driver: Rider
    {
        public Driver(ClaimsPrincipal principal): base(principal)
        {

        }

        public override bool isRider()
        {
            return true;
        }

        public override bool isDriver()
        {
            return true;
        }

    }

}
