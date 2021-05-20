using MobileShop.Data;
using MobileShop.Entities;
using MobileShop.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileShop.Repository
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly DataContext _dataContext;

        public ManufacturerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(Manufacturer manufacturer)
        {
            _dataContext.Manufacturers.Add(manufacturer);
            _dataContext.SaveChanges();
        }

        public void Delete(Manufacturer manufacturer)
        {
            _dataContext.Manufacturers.Remove(manufacturer);
            _dataContext.SaveChanges();
        }

        public void Edit(Manufacturer manufacturer)
        {
            _dataContext.Manufacturers.Update(manufacturer);
            _dataContext.SaveChanges();
        }

        public Manufacturer GetManufacturerByID(int id)
        {
            var result = _dataContext.Manufacturers.FirstOrDefault(x => x.ManufactuterID == id);
            return result;
        }

        public IEnumerable<Manufacturer> GetManufacturers()
        {
            var result = _dataContext.Manufacturers.AsEnumerable();
            return result;
        }
    }
}
