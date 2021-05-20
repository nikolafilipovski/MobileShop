using MobileShop.Entities;
using MobileShop.Repository.Interfaces;
using MobileShop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Service
{
    public class PhoneService : IPhoneService
    {
        private readonly IPhoneRepository _phoneRepository;

        public PhoneService(IPhoneRepository phoneRepository)
        {
            _phoneRepository = phoneRepository;
        }

        public void Add(Phone phone)
        {
            _phoneRepository.Add(phone);
        }

        public void Delete(Phone phone)
        {
            _phoneRepository.Delete(phone);
        }

        public void Edit(Phone phone)
        {
            _phoneRepository.Edit(phone);
        }

        public Phone GetPhoneByID(int id)
        {
            var result = _phoneRepository.GetPhoneByID(id);
            return result;
        }

        public IEnumerable<Phone> GetPhones()
        {
            var result = _phoneRepository.GetPhones();
            return result;
        }
    }
}
