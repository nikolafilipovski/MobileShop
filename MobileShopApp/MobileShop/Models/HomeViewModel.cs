using MobileShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Phone> AllPhones { get; set; }

    }
}
