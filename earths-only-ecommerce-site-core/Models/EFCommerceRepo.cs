using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace earths_only_ecommerce_site_core.Models
{
    public class EFCommerceRepo : ICommerceRepo
    {

        private AppDbContext context;

        //Constructor
        public EFCommerceRepo(AppDbContext context)
        {
            this.context = context;

        }

        public IQueryable<ItemForSale> Items => context.Items;

        public IQueryable<Category> Categories =>context.Categories;

        public IQueryable<Order> Orders => context.Orders;

        public IQueryable<Seller> Sellers => context.Sellers;

        public IQueryable<User> Users => context.Users;

        public IQueryable<Picture> Pictures => context.Pictures;

        //Post
        public string CreateItemForSale(ItemForSale item)
        {
            throw new NotImplementedException();
        }

        public ItemForSale DeleteItemForSale(string id)
        {
            throw new NotImplementedException();
        }

        //GET 1 item
        public ItemForSale GetOneItem(string id)
        {
            throw new NotImplementedException();
        }
    }
}
