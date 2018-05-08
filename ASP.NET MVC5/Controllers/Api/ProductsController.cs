using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASP.NET_MVC5.Models;

namespace ASP.NET_MVC5.Controllers.Api
{
    public class ProductsController : ApiController
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

        public IHttpActionResult GetProducts()
        {
            var products = _context.Products
                .Select(
                    p =>
                        new
                        {
                            p.ProductID,
                            p.ProductName,
                            p.Category.CategoryName
                        }
                );

            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);
        }

    }
}
