using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        // GET: Products/details
        public ActionResult details(string ProductName)
        {
            ViewBag.ProductName = ProductName;
            return View();
        }
    }
}