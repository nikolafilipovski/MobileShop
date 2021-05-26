using MobileShop.Entities;
using MobileShop.Repository.Interfaces;
using MobileShop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Add(Order order)
        {
            _orderRepository.Add(order);
        }

        public void Delete(Order order)
        {
            _orderRepository.Delete(order);
        }

        public void Edit(Order order)
        {
            _orderRepository.Edit(order);
        }

        public Order GetOrderByID(int id)
        {
            var result = _orderRepository.GetOrderByID(id);
            return result;
        }

        public IEnumerable<Order> GetOrders()
        {
            var result = _orderRepository.GetOrders();
            return result;
        }
    }
}
