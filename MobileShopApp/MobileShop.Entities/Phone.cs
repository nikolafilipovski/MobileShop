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
        public string PhotoURL { get; set; }
        public string Manufacturer { get; set; }
    }
}
