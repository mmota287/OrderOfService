using OrderOfService.Data.Entities;
using System.Collections.Generic;

namespace OrderOfService.Business.Orders
{
    public interface IOrderService
    {
        void AddOrder(Order order);

        void PayOrder(Order order);

        void CancelOrder(Order order);
        IEnumerable<Order> GetAllOrders();
    }
}
