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
                    new ItemForSale { ItemDescription = "Notebook, plain", ItemName = "Notebook black", InStock=10, ItemPrice=10, Picture= "https://5.imimg.com/data5/WQ/LE/MY-35609268/stationery-notebook-500x500.jpg" },
                    new ItemForSale { ItemDescription = "A durable pen", ItemName = "Ink pen", InStock = 100, ItemPrice = 25, Picture= "https://5.imimg.com/data5/AU/YL/MY-33953112/fountain-ink-pen-500x500.png" },
                    new ItemForSale { ItemDescription = "Folders of different colors", ItemName = "Folder", InStock = 52, ItemPrice = 40, Picture= "http://www.tarifold.com/wp-content/uploads/2019/06/L-Folders-Color-collection-Tarifold.jpg" },
                    new ItemForSale { ItemDescription = "Paper weight, different colors available", ItemName = "Paper weight", InStock = 0, ItemPrice = 150, Picture= "https://www.janeausten.co.uk/wp-content/uploads/2016/10/paper-weight-jane-austen-4.jpg" }
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
