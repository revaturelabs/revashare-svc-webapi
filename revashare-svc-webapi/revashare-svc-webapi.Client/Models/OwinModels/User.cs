using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace revashare_svc_webapi.Client.Models.OwinModels
{
    public class User : ClaimsPrincipal
    {



        public string userName
        {
            get
            {
                return this.FindFirst(ClaimTypes.Name).Value;
            }
        }
        

        public User(ClaimsPrincipal principal) : base(principal)
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
}