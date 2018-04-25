using Ninject;
using Ninject.Web.Mvc;
using StrongKeys.Service;
using StrongKeys.WebRunner.Modules;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace StrongKeys.WebRunner
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DependencyResolver.SetResolver(new NinjectDependencyResolver(new StandardKernel(new CryptoModule(), new WebModule(), new DBModule())));
        }
    }
}
//C:\mongodb\bin\mongod.exe --dbpath C:\mongodb\data