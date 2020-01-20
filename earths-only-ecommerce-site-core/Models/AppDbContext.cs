using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using earths_only_ecommerce_site_core.Models;
using Microsoft.EntityFrameworkCore;

namespace earths_only_ecommerce_site_core.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ItemForSale> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
