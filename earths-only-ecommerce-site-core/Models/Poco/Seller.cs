using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace earths_only_ecommerce_site_core.Models
{
    public class Seller
    {

        public int SellerId { get; set; } //primary key

        public string UserName { get; set; }
        public string Email { get; set; }
        public string RoleTitle { get; set; }

        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public int CreditCard { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
    }
}
