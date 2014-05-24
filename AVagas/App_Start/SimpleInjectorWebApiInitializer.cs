using AVagas.Core.Data;
using AVagas.Core.Data.EF;

[assembly: WebActivator.PostApplicationStartMethod(typeof(AVagas.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace AVagas.App_Start
{
    using System.Web.Http;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    
    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            // Did you know the container can diagnose your configuration? Go to: https://bit.ly/YE8OJj.
            var container = new Container();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {
            container.RegisterWebApiRequest<IAVagasContext,AVagasContextEF>();

            // For instance:
            // container.RegisterWebApiRequest<IUserRepository, SqlUserRepository>();
        }
    }
}