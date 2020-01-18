using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace earths_only_ecommerce_site_core.Models
{
    public class Category
    {

        public int CategoryId { get; set; }  //primary key

        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

    }
}
