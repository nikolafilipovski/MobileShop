using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobileShop.Entities
{
    public class Phone
    {
        [Key]
        public int PhoneID { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(20)]
        public string Price { get; set; }

        [StringLength(50)]
        public string Display { get; set; }

        [StringLength(50)]
        public string Memory { get; set; }

        [StringLength(50)]
        public string Battery { get; set; }

        [Display(Name = "Photo")]
        public string PhotoURL { get; set; }

        [Display(Name = "Manufacturer")]
        public string ManufacturerName { get; set; }
        public int ManufacturerID { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
