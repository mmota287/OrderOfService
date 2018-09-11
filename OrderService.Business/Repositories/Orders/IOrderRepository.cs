using OrderOfService.Business.Entities;
using System.Collections.Generic;

namespace OrderOfService.Business.Repositories.Orders
{
    public interface IOrderRepository
    {
        bool InsertOrder(Order order);

        bool UpdateOrder(Order order);

        IEnumerable<Order> GetAll();
    }
}
