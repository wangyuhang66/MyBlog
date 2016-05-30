using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MyBlogBackground
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            MyBlogFacade.InitReferenceEnv.InitSubAssembliesEnv(System.Web.Configuration.WebConfigurationManager.AppSettings["MyBlogDbConn"]);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
