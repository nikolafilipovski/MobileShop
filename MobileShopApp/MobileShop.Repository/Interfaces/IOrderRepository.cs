using MobileShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Repository.Interfaces
{
    public interface IOrderRepository
    {
        void Add(Order order);
        void Edit(Order order);
        void Delete(Order order);
        Order GetOrderByID(int id);
        IEnumerable<Order> GetOrders();
    }
}
