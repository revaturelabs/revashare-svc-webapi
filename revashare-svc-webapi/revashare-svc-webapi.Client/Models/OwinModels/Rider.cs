using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Claims;


namespace revashare_svc_webapi.Client.Models.OwinModels
{
    public class Rider : User
    {
        public Rider(ClaimsPrincipal principal) : base(principal)
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

}