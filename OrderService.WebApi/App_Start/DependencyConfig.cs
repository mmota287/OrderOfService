using OrderOfService.Business.Context;
using OrderOfService.Business.Repositories.Orders;
using OrderOfService.Business.Services;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;

namespace OrderOfService.WebApi.App_Start
{
    public static class DependencyConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            container.Register<OrderContext>(Lifestyle.Scoped);
            container.Register<IOrderRepository, OrderRepository>();
            container.Register<IOrderService, OrderService>();
            container.RegisterWebApiControllers(config);
            container.Verify();

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}