using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace revashare_svc_webapi.Client
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            
            var cors = new EnableCorsAttribute(
            origins: "*",
            headers: "*",
            methods: "*");

            config.EnableCors(cors);
            
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
