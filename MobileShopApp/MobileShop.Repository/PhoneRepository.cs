using MobileShop.Data;
using MobileShop.Entities;
using MobileShop.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileShop.Repository
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly DataContext _dataContext;

        public PhoneRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(Phone phone)
        {
            _dataContext.Phones.Add(phone);
            _dataContext.SaveChanges();
        }

        public void Delete(Phone phone)
        {
            _dataContext.Phones.Remove(phone);
            _dataContext.SaveChanges();
        }

        public void Edit(Phone phone)
        {
            _dataContext.Phones.Update(phone);
            _dataContext.SaveChanges();
        }

        public Phone GetPhoneByID(int id)
        {
            var result = _dataContext.Phones.FirstOrDefault(x => x.PhoneID == id);
            return result;
        }

        public IEnumerable<Phone> GetPhones()
        {
            var result = _dataContext.Phones.AsEnumerable();
            return result;
        }
    }
}
