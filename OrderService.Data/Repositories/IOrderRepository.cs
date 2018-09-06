using OrderOfService.Data.Entities;
using System.Collections.Generic;

namespace OrderOfService.Data.Repositories
{
    public interface IOrderRepository
    {
        bool InsertOrder(Order order);

        bool UpdateOrder(Order order);

        IEnumerable<Order> GetAll();
    }
}
