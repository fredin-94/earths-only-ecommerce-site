using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace earths_only_ecommerce_site_core.Models
{
    public class InitialData
    {

        public static void EnsureData(IServiceProvider services)
        {

            var context = services.GetRequiredService<AppDbContext>();

            if (!context.Items.Any())
            {
                context.Items.AddRange(
                    new ItemForSale { ItemDescription = "Notebook, plain", ItemName = "Notebook black", InStock=10, ItemPrice=10 },
                    new ItemForSale { ItemDescription = "A durable pen", ItemName = "Ink pen", InStock = 100, ItemPrice = 25 },
                    new ItemForSale { ItemDescription = "Folders of different colors", ItemName = "Folder", InStock = 52, ItemPrice = 40 },
                    new ItemForSale { ItemDescription = "Paper weight, different colors available", ItemName = "Paper weight", InStock = 0, ItemPrice = 150 }
                );
                context.SaveChanges();
            }

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category { CategoryName="Office supplies", CategoryDescription="Anything for your office"},
                    new Category { CategoryName="Hobby items", CategoryDescription="None"},
                    new Category { CategoryName="Useless items", CategoryDescription="But you will still love them!"},
                    new Category { CategoryName="Tech items", CategoryDescription="The latest n greatest"}
                );
                context.SaveChanges();
            }

            if (!context.Admins.Any())
            {
                context.Admins.AddRange(
                   new Admin { AdminUserName = "Admin1", RoleTitle = "Admin" }
                
                );
                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User { UserName = "User1", RoleTitle = "User", Email = "" }
                );
                context.SaveChanges();
            }

            if (!context.Sellers.Any())
            {
                context.Sellers.AddRange(
                    new Seller { UserName="Seller1", CompanyName = "Solstice", Email = "sellstuff@solstice.now", RoleTitle = "Seller" }
                );
                context.SaveChanges();
            }
        }
    }
}
