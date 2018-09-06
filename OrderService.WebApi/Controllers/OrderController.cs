using OrderOfService.Business.Orders;
using OrderOfService.Data.Entities;
using OrderOfService.Data.Repositories;
using System.Web.Http;

namespace OrderOfService.WebApi.Controllers
{
    [RoutePrefix("api/orders")]
    public class OrderController : ApiController
    {
        private IOrderService orderService;
        public OrderController()
        {
            orderService = new OrderService(new OrderRepository(new Data.Context.OrderContext()));
        }

        [Route("add")]
        [HttpPost]
        public IHttpActionResult AddOrder(Order order)
        {
            if (ModelState.IsValid)
                return BadRequest(ModelState);

            orderService.AddOrder(order);
            return Ok("Ordem de serviço foi criada com sucesso.");

        }

        [Route("cancel")]
        [HttpPost]
        public IHttpActionResult CancelOrder(Order order)
        {
            if (ModelState.IsValid)
                return BadRequest(ModelState);

            orderService.CancelOrder(order);
            return Ok("Ordem de serviço foi cancelada com sucesso.");
        }

        [Route("pay")]
        [HttpPost]
        public IHttpActionResult PayOrder(Order order)
        {
            if (ModelState.IsValid)
                return BadRequest(ModelState);

            orderService.PayOrder(order);
            return Ok("Ordem de serviço foi baixada com sucesso.");
        }

        [Route]
        [HttpGet]
        public IHttpActionResult GetOrders()
        {
            var orders = orderService.GetAllOrders();
            return Ok(orders);
        }
    }
}