using OrderOfService.Business.Entities;
using System.Collections.Generic;

namespace OrderOfService.Business.Services
{
    public interface IOrderService
    {
        void AddOrder(Order order);

        void PayOrder(Order order);

        void CancelOrder(Order order);
        IEnumerable<Order> GetAllOrders();
    }
}
