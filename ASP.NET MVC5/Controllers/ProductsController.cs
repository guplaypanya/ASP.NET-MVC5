using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC5.Models;

namespace ASP.NET_MVC5.Controllers
{
    public class ProductsController : Controller
    {
        public NorthwindDbcontext _context;

        public ProductsController()
        {
            _context = new NorthwindDbcontext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return Redirect("Index");
        }

    }
}