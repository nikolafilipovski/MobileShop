using MobileShop.Data;
using MobileShop.Entities;
using MobileShop.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileShop.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _dataContext;

        public OrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(Order order)
        {
            _dataContext.Orders.Add(order);
            _dataContext.SaveChanges();
        }

        public void Delete(Order order)
        {
            _dataContext.Orders.Remove(order);
            _dataContext.SaveChanges();
        }

        public void Edit(Order order)
        {
            _dataContext.Orders.Update(order);
            _dataContext.SaveChanges();
        }

        public Order GetOrderByID(int id)
        {
            var result = _dataContext.Orders.FirstOrDefault(x => x.OrderID == id);
            return result;
        }

        public IEnumerable<Order> GetOrders()
        {
            var result = _dataContext.Orders.AsEnumerable();
            return result;
        }
    }
}
