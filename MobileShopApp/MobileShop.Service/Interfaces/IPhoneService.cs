using Microsoft.AspNetCore.Mvc.Rendering;
using MobileShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Service.Interfaces
{
    public interface IPhoneService
    {
        void Add(Phone phone);
        void Edit(Phone phone);
        void Delete(Phone phone);
        Phone GetPhoneByID(int id);
        IEnumerable<Phone> GetPhones();
        IEnumerable<SelectListItem> ManufacturerDropdown(IEnumerable<Manufacturer> manufacturers);
    }
}
