using OrderOfService.Business.Context;
using OrderOfService.Business.Repositories.Orders;
using OrderOfService.Business.Services;
using OrderOfService.WebApi.App_Start;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace OrderOfService.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Create the container as usual.
            DependencyConfig.Register(GlobalConfiguration.Configuration);

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
