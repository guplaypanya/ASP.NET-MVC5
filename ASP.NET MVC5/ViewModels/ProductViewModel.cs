using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET_MVC5.Models;

namespace ASP.NET_MVC5.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}