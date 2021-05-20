using MobileShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Repository.Interfaces
{
    public interface IPhoneRepository
    {
        void Add(Phone phone);
        void Edit(Phone phone);
        void Delete(Phone phone);
        Phone GetPhoneByID(int id);
        IEnumerable<Phone> GetPhones();
    }
}
