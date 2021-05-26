using Microsoft.AspNetCore.Mvc.Rendering;
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

        #region Dropdown

        public IEnumerable<SelectListItem> ManufacturerDropdown(IEnumerable<Manufacturer> manufacturers)
        {
            List<SelectListItem> Manufacturers = new List<SelectListItem>()
            {
                new SelectListItem() { Value = "0", Text = "Select a manufacturer ..."}
            };

            foreach (var item in manufacturers)
            {
                Manufacturers.Add(new SelectListItem() { Value = item.ManufactuterID.ToString(), Text = item.Name, Selected = false });
            }
            return Manufacturers;
        }

        #endregion

    }
}
