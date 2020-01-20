using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace earths_only_ecommerce_site_core.Models
{
    public class ItemForSale
    {
        [Key]
        public int ItemId { get; set; }  //primary key

        [Display(Name = "Name of product: ")]
        [Required(ErrorMessage = "You must provide a name")]
        public string ItemName { get; set; }

        [Display(Name = "Description of product: ")]
        [Required(ErrorMessage = "You must provide a description")]
        public string ItemDescription { get; set; }

        [Display(Name = "Price of product: ")]
        [Required(ErrorMessage = "You must provide a price")]
        public int ItemPrice { get; set; }

        [Display(Name = "Amount available of the product: ")]
        [Required(ErrorMessage = "You must provide the amount")]
        [DataType(DataType.Currency)]
        public int InStock { get; set; }

        [Display(Name = "Product rating: ")]
        public int Rating { get; set; }

        public string Picture { get; set; } //maybe better to only have 1 img per prduct

        //foreign key
        public int SellerId { get; set; }
        public int CategoryId { get; set; }
    }
}
