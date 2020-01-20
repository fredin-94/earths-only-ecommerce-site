using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace earths_only_ecommerce_site_core.Models
{
    public interface ICommerceRepo
    {

        //
        IQueryable<ItemForSale> Items { get; }
        IQueryable<Category> Categories { get; }
        IQueryable<Order> Orders { get; }
        IQueryable<Seller> Sellers { get; }
        IQueryable<User> Users { get; }

        //
        ItemForSale GetOneItem(int id);

        //
        string CreateItemForSale(ItemForSale item);

        //
        ItemForSale DeleteItemForSale(int id);

    }
}
