using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace revashare_svc_webapi.Client.Models
{


    public class signupModel
    {

        public string email { get; set; }

        public string userName { get; set; }

        public string password { get; set; }

    }


    public class loginModel
    {


        public string email { get; set; }

        public string userName { get; set; }

        public string password { get; set; }

    }

}
