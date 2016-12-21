
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;


[assembly: OwinStartup(typeof(revashare_svc_webapi.Client.Startup))]
namespace revashare_svc_webapi.Client
{
    public partial class Startup
    {
       
        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                CookieName = "revashareAuth",
                CookieSecure = CookieSecureOption.Never,
                LoginPath = new PathString("/api/account/login"),
                LogoutPath = new PathString("/api/account/logout")
            });

        }

    }
}
