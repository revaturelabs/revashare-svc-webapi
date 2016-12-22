﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace revashare_svc_webapi.Client.Models.OwinModels
{
    public class UserFactory
    {

        private static UserFactory _factory = null;
        private static string USER_TYPE = "user";
        private static string RIDER_TYPE = "rider";
        private static string DRIVER_TYPE = "driver";
        private static string ADMIN_TYPE = "admin";

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
            else if (roleName.Equals(ADMIN_TYPE))
            {
                return new OwinModels.Admin(principal);
            }
            else
            {
                return null;
            }
        }

    }
}