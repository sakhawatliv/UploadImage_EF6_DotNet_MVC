using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleImageUpload.Database;
using SimpleImageUpload.Models;

namespace SimpleImageUpload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddImage()
        {
            Brand b1 = new Brand();
            return View(b1);
        }
        [HttpPost]
        public ActionResult AddImage(Brand model, HttpPostedFileBase image1)
        {
            var db = new ImageUploadDbContext();
            if (model != null)
            {
                model.BrandImage = new byte[image1.ContentLength];
                image1.InputStream.Read(model.BrandImage, 0, image1.ContentLength);
            }
            db.Brands.Add(model);
            db.SaveChanges();
            return View(model);

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}