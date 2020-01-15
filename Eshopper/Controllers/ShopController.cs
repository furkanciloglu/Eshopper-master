using Eshopper.Areas.Admin.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eshopper.Controllers
{
    public class ShopController : Controller
    {
        private productRepository pmngr;
        public ShopController()
        {
            pmngr = new productRepository(new Areas.Admin.Models.AppDbContext.Context());
        }
        // GET: Shop
        public ActionResult Products()
        {
            return View(pmngr.getAll());
        }
    }
}