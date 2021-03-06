[assembly: WebActivator.PostApplicationStartMethod(typeof(revashare_svc_webapi.Client.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace revashare_svc_webapi.Client.App_Start
{
    using System.Web.Http;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using Logic.Interfaces;
    using Logic.ServiceClient;
    using Logic.AdminLogic;
    using Logic;
    using Logic.RiderLogic;
    using Logic.UserLogic;

    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            //container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {

            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
            container.Register<IServiceClient, ServiceClient>(Lifestyle.Transient);
            container.Register<IAdmin, AdminLogic>(Lifestyle.Transient);
            container.Register<IDriverRepository, DriverLogic>(Lifestyle.Transient);
            container.Register<IRider, RiderLogic>(Lifestyle.Transient);
            container.Register<IUser, UserLogic>(Lifestyle.Transient);
        }
    }
}