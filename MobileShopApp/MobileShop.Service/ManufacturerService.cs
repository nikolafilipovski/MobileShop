using MobileShop.Entities;
using MobileShop.Repository.Interfaces;
using MobileShop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Service
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly IManufacturerRepository _manufacturerRepository;

        public ManufacturerService(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }

        public void Add(Manufacturer manufacturer)
        {
            _manufacturerRepository.Add(manufacturer);
        }

        public void Delete(Manufacturer manufacturer)
        {
            _manufacturerRepository.Delete(manufacturer);
        }

        public void Edit(Manufacturer manufacturer)
        {
            _manufacturerRepository.Edit(manufacturer);
        }

        public Manufacturer GetManufacturerByID(int id)
        {
            var result = _manufacturerRepository.GetManufacturerByID(id);
            return result;
        }

        public IEnumerable<Manufacturer> GetManufacturers()
        {
            var result = _manufacturerRepository.GetManufacturers();
            return result;
        }
    }
}
