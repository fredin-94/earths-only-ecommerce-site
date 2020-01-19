using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace earths_only_ecommerce_site_core.Models
{
    public class InitialIdentityData
    {

        public static async Task EnsureData(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            await CreateRoles(roleManager);
            await CreateUsers(userManager);
        }

        private static async Task CreateRoles(RoleManager<IdentityRole> rManager)
        {

            if (!await rManager.RoleExistsAsync("User"))
            {
                await rManager.CreateAsync(new IdentityRole("User"));
            }

            if (!await rManager.RoleExistsAsync("Admin"))
            {
                await rManager.CreateAsync(new IdentityRole("Admin"));
            }

            if (!await rManager.RoleExistsAsync("Seller"))
            {
                await rManager.CreateAsync(new IdentityRole("Seller"));
            }
        }

        private static async Task CreateUsers(UserManager<IdentityUser> uManager)
        {

            IdentityUser User1 = new IdentityUser("User1");
            IdentityUser Seller1 = new IdentityUser("Seller1");
            IdentityUser Admin1 = new IdentityUser("Admin1");
            await uManager.CreateAsync(User1, "Pas51!"); 
            await uManager.CreateAsync(Seller1, "Pas51!"); 
            await uManager.CreateAsync(Admin1, "Pas51!");

            //assign roles to ppl:
            await uManager.AddToRoleAsync(User1, "User");
            await uManager.AddToRoleAsync(Seller1, "Seller");
            await uManager.AddToRoleAsync(Admin1, "Admin");

        }
    }
}
