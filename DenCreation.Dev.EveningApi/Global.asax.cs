﻿using System.Web;
using System.Web.Http;
using System.Web.Optimization;
using System.Web.Routing;

namespace DenCreation.Dev.EveningApi
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
