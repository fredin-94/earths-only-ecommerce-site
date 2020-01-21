using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace earths_only_ecommerce_site_core.Controllers
{
    public class ShoppingCartController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cart(string itemId)
        {
            return View();
        }

    }
}
