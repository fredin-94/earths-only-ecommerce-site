using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace earths_only_ecommerce_site_core.Models
{
    public class Order
    {

        public int OrderId { get; set; }  //primary key

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        public int OrderNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime ShippingDate { get; set; }

        public int ShippingCost { get; set; }



        //foreign keys:
        public int UserId { get; set; }
        public int SellerId { get; set; }

    }
}
