using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace revashare_svc_webapi.Client.Models.OwinModels
{
    public class Admin : User
    {
        public Admin(ClaimsPrincipal principal) : base(principal)
        {

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