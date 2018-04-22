using CartsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CartsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            using (CartsDataContext db = new CartsDataContext())
            {
                var result = (from s in db.Products select s).ToList();
                return View(result);
            }
        }

        public ActionResult Details(int id)
        {
            using (CartsDataContext db = new CartsDataContext())
            {
                var result = db.Products.Where(p => p.Id == id).FirstOrDefault();
                return View(result);
            }
        }
    }
}
