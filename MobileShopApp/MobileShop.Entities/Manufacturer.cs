using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobileShop.Entities
{
    public class Manufacturer
    {
        [Key]
        public int ManufactuterID { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Country { get; set; }

        [Display(Name = "Logo")]
        public string LogoURL { get; set; }

        public ICollection<Phone> Phones { get; set; }
    }
}
