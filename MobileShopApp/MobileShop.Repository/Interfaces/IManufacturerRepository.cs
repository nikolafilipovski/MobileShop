using MobileShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Repository.Interfaces
{
    public interface IManufacturerRepository
    {
        void Add(Manufacturer manufacturer);
        void Edit(Manufacturer manufacturer);
        void Delete(Manufacturer manufacturer);
        Manufacturer GetManufacturerByID(int id);
        IEnumerable<Manufacturer> GetManufacturers();
    }
}
