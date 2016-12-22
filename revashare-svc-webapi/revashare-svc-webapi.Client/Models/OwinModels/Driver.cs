using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace revashare_svc_webapi.Client.Models.OwinModels
{
    public class Driver : Rider
    {
        public Driver(ClaimsPrincipal principal) : base(principal)
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