using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC5.Models;

namespace ASP.NET_MVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var dbContext = new NorthwindDbcontext();
            var products = dbContext.Products.ToList();

            foreach (var product in products)
            {
                Debug.WriteLine(product.ProductName);
            }

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