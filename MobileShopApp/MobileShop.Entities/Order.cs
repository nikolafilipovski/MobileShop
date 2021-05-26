using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobileShop.Entities
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(20)]
        public string City { get; set; }
        public int PhoneID { get; set; }
        public Phone Phone { get; set; }
    }
}
