using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace earths_only_ecommerce_site_core.Models
{
    public class Admin
    {

        public int AdminId { get; set; } //primary key

        public string AdminUserName { get; set; }

        public string RoleTitle { get; set; }

    }
}
