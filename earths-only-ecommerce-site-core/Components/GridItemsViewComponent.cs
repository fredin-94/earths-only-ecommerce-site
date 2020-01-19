using earths_only_ecommerce_site_core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace earths_only_ecommerce_site_core.Components
{
    public class GridItemsViewComponent : ViewComponent
    {

        private IHttpContextAccessor contextAccessor;
        private ICommerceRepo repo; //get access to DB so we can display items for sale

        public GridItemsViewComponent(IHttpContextAccessor contextAccessor, ICommerceRepo repo)
        {
            this.contextAccessor = contextAccessor;
            this.repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.ItemsForSale = repo.Items.ToArray();

            ItemForSale[] items = repo.Items.ToArray();

            return View("GridItems", items);
        }


        }
    }
