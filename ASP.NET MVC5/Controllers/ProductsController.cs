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
        private NorthwindDbcontext _context;

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
            var products = _context.Products.ToList();

            return View(products);
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
            {
                HttpNotFound();
            }

            return View(product);
        }

        [HttpPost]
        public ActionResult Save(Product product)
        {

            if (product.ProductID == 0)
            {
                _context.Products.Add(product);
            }
            else
            {
                var productInDb = _context.Products.Find(product.ProductID);

                productInDb.ProductName = product.ProductName;
            }
            
            _context.SaveChanges();

            return Redirect("Index");
        }

    }
}