using OrderOfService.Data.Entities;
using OrderOfService.Data.Enums;
using OrderOfService.Data.Repositories;
using System;
using System.Collections.Generic;

namespace OrderOfService.Business.Orders
{
    public class OrderService : IOrderService
    {
        private IOrderRepository orderRepository;

        public OrderService(IOrderRepository _orderRepository)
        {
            orderRepository = _orderRepository;
        }

        public void AddOrder(Order order)
        {
            order.DateCreated = DateTime.Now;
            order.Status = OrderStatus.PENDING;
            orderRepository.InsertOrder(order);
        }

        public void CancelOrder(Order order)
        {
            order.DateEnded = DateTime.Now;
            order.Status = OrderStatus.CANCELLED;
            orderRepository.UpdateOrder(order);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return orderRepository.GetAll();
        }

        public void PayOrder(Order order)
        {
            order.DateEnded = DateTime.Now;
            order.Status = OrderStatus.PAID;
            orderRepository.UpdateOrder(order);
        }
    }
}
