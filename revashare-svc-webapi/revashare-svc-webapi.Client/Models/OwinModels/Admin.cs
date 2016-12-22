using revashare_svc_webapi.Logic.AdminLogic;
using revashare_svc_webapi.Logic.Interfaces;
using revashare_svc_webapi.Logic.ServiceClient;
using System.Security.Claims;
using System.Web;

namespace revashare_svc_webapi.Client.Models.OwinModels
{
    public class Admin : User
    {

        private IAdmin logic;

        public Admin(ClaimsPrincipal principal) : base(principal)
        {
            this.logic = new AdminLogic(new ServiceClient());
        }

        public override bool isRider()
        {
            return false;
        }

        public override bool isDriver()
        {
            return false;
        }

    }

}