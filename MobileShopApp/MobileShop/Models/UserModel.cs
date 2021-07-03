using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class UserModel
    {
        [Key]
        public string UserID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+\\.)+[a-z]{2,5}$", ErrorMessage = "E-mail not valid!")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public IQueryable<SelectListItem> Roles { get; set; }

        public string RoleId { get; set; }

        public string RoleName { get; set; }
    }
}
