using Eshopper.Areas.Admin.Models.Entites;
using Eshopper.Areas.Admin.Models.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eshopper.Areas.Admin.Controllers
{
    public class productController : Controller
    {
        private productRepository mngr;
        private brandRepository bmngr;
        private categoryRepository cmngr;
        public productController()
        {
            mngr = new productRepository(new Models.AppDbContext.Context());
            bmngr = new brandRepository(new Models.AppDbContext.Context());
            cmngr = new categoryRepository(new Models.AppDbContext.Context());
        }
        // GET: Admin/category
        public ActionResult Index()
        {
            return View(mngr.getAll());
        }
        public ActionResult Create()
        {
            ViewBag.Brands = bmngr.getAll();
            ViewBag.Categories = cmngr.getAll();
            return View();
        }
        // Kaydetme 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product model, HttpPostedFileBase image1)
        {
            model.created = DateTime.Now;
            if (ModelState.IsValid)
            {
                if (image1 != null)
                {
                    using (var br = new BinaryReader(image1.InputStream))
                    {
                        var data = br.ReadBytes(image1.ContentLength);
                         model.img = data;
                    }

                }

                mngr.Save(model);
            }
            return RedirectToAction("/");
        }
        public ActionResult Edit(int id)
        {
            ViewBag.Brands = bmngr.getAll();
            ViewBag.Categories = cmngr.getAll();
            return View(mngr.Get(id));
        }
        //değiştirme
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product model, HttpPostedFileBase image1)
        {
            model.created = DateTime.Now;
            if (ModelState.IsValid)
            {
                if (image1 != null)
                {
                    using (var br = new BinaryReader(image1.InputStream))
                    {
                        var data = br.ReadBytes(image1.ContentLength);
                        model.img = data;
                    }
                }
                mngr.Update(model);
            }
            return RedirectToAction("/");
        }
        public ActionResult Delete(int id)
        {
            return View(mngr.Get(id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteProduct(int id)
        {
            if (ModelState.IsValid)
                mngr.Delete(mngr.Get(id));
            return RedirectToAction("/");
        }
    }
}