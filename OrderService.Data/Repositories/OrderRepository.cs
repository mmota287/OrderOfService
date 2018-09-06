using OrderOfService.Data.Context;
using OrderOfService.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderOfService.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private OrderContext context;
        public OrderRepository(OrderContext _context)
        {
            context = _context;
        }

        public IEnumerable<Order> GetAll()
        {
            return context.Orders.ToList();
        }

        public bool InsertOrder(Order order)
        {
            try
            {
                context.Orders.Add(order);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateOrder(Order order)
        {
            context.Orders.Attach(order);
            context.SaveChanges();
            return true;
        }
    }
}
