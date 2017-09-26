using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DevFramework.Core.Utilities.Mvc.Infrastructure;
using DevFramework.Northwind.Business.DependencyResolvers.Ninject;

namespace DevFramework.Northwind.MvcWebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BusinessModule()));
        }
    }
}
