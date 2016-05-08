using System.Web.Http;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using Turnover.Command.Implementation;
using Turnover.EntityFramework;
using Turnover.Query.Implementation;

namespace Turnover.WebApi
{
    public static class DiContainerConfig
    {
        public static void Initialize()
        {
            // Simple Injector set up
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            // Register your stuff here  
            Register(container);
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void Register(Container container)
        {
            new EntityFrameworkInjector().Register(container);
            new CommandInjector().Register(container);
            new QueryInjector().Register(container);
        }
    }
}