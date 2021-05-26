using MobileShop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class PhoneViewModel
    {
        #region PhoneData

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

        #endregion

        #region ManufacturerData

        [Key]
        public int ManufactuterID { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Country { get; set; }

        [Display(Name = "Logo")]
        public string LogoURL { get; set; }

        #endregion

        #region OrderData

        [Key]
        public int OrderID { get; set; }

        [StringLength(20)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(20)]
        public string City { get; set; }
        public Phone Phone { get; set; }

        #endregion
    }
}
