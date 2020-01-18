using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace earths_only_ecommerce_site_core.Models
{
    public class LoginModel
    {

        [Required(ErrorMessage = "Enter username")]
        [Display(Name = "Username: ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter password")]
        [Display(Name = "Password: ")]
        [UIHint("Password")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

    }
}
