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
            context.Items.Add(item);
            context.SaveChanges();

            return "Item Saved"; //change later
        }

        public ItemForSale DeleteItemForSale(int id)
        {

            ItemForSale item = context.Items.Where(itemToFind => itemToFind.ItemId == id).FirstOrDefault();

            if (item != null) {
                context.Items.Remove(item);
            }
            context.SaveChanges();

            return item;

        }

        //GET 1 item
        public ItemForSale GetOneItem(int id)
        {

            var item = context.Items.Where(itemToFind => itemToFind.ItemId == id).FirstOrDefault();

            return item;

        }
    }
}
