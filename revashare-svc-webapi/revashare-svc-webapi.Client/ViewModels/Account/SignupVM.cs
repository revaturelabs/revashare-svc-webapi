using revashare_svc_webapi.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace revashare_svc_webapi.Client.ViewModels.Account
{
    public class SignupVM
    {

        public UserDTO user { get; set; }

        public string password { get; set; }


        public bool isValid()
        {
            if (password.Length < 8)
            {
                return false;
            }

            if (user.Name == null 
                || user.Email == null 
                || user.PhoneNumber == null
                || user.UserName == null)
            {
                return false;
            }

            return true;

        }

    }
}