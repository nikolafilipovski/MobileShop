using MobileShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Service.Interfaces
{
    public interface IOrderService
    {
        void Add(Order order);
        void Edit(Order order);
        void Delete(Order order);
        Order GetOrderByID(int id);
        IEnumerable<Order> GetOrders();
    }
}
