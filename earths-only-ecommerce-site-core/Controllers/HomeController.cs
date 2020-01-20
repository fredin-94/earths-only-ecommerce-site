using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using earths_only_ecommerce_site_core.Models;
using earths_only_ecommerce_site_core.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace earths_only_ecommerce_site_core.Controllers
{
    public class HomeController : Controller
    {

        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;
        private IHttpContextAccessor contextAccessor;


        private ICommerceRepo repo;

        //Constructor
        public HomeController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ICommerceRepo repo, IHttpContextAccessor contextAccessor)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.contextAccessor = contextAccessor;


            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string returnUrl) //Login page
        {
            ViewData["Message"] = "Login page.";

            return View(new LoginModel
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel) //Log in and redirect user 
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(loginModel.UserName);

                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    if ((await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false)).Succeeded)
                    {

                        if (await userManager.IsInRoleAsync(user, "User"))
                        {
                            return Redirect(loginModel?.ReturnUrl ?? "/User/Index");
                        }
                        else if (await userManager.IsInRoleAsync(user, "Admin"))
                        {
                            return Redirect(loginModel?.ReturnUrl ?? "/Admin/Index");
                        }
                        else if (await userManager.IsInRoleAsync(user, "Seller"))
                        {
                            return Redirect(loginModel?.ReturnUrl ?? "/Seller/Index");
                        }
                    }
                }
            }

            ModelState.AddModelError("", "Wrong username or password");
            return View(loginModel);
        }

        //Log out and redirect user
        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await signInManager.SignOutAsync();
            return Redirect(returnUrl);
        }

        //Access denied page
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        ///////////////VIEWS////////////////
        //shopping
        public IActionResult Shopping()
        {
            return View();
        }

        public IActionResult SingleItem(int id)
        {
            //find single item in db, send to view, display it

            ViewBag.SelectedItem = repo.GetOneItem(id);

            bool loggedIn = false;

            if (contextAccessor.HttpContext.User.IsInRole("User"))
            {
                loggedIn = true;
            }

            ViewBag.LoggedIn = loggedIn;

            return View();
        }

        //about
        public IActionResult About()
        {
            return View();
        }

        //privacy
        public IActionResult Privacy()
        {
            return View();
        }

        //made by the system:
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
