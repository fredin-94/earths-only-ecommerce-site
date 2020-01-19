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

        public GridItemsViewComponent(IHttpContextAccessor contextAccessor)
        {
            this.contextAccessor = contextAccessor;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }


        }
    }
