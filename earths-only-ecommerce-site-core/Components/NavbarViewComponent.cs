using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace earths_only_ecommerce_site_core.Components
{
    public class NavbarViewComponent : ViewComponent
    {
        private IHttpContextAccessor contextAccessor;

        public NavbarViewComponent(IHttpContextAccessor contextAccessor)
        {
            this.contextAccessor = contextAccessor;
        }

        public IViewComponentResult Invoke()
        {

            string role = "";
            bool signedIn = false;

            if (contextAccessor.HttpContext.User.IsInRole("User"))
            {
                role = "User";
                signedIn = true;

            }
            else if (contextAccessor.HttpContext.User.IsInRole("Seller"))
            {
                role = "Seller";
                signedIn = true;

            }
            else if (contextAccessor.HttpContext.User.IsInRole("Admin"))
            {
                role = "Admin";
                signedIn = true;

            }
            else
            {
                role = "";
                signedIn = false;
            }

            ViewBag.UserRole = role;
            ViewBag.UserIsSignedIn = signedIn;

            return View("Navbar");
        }

    }
}
