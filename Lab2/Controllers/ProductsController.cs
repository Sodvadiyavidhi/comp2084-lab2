using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            
            string[] product ={ "Laptop","Tablet","Desktop" };
            ViewBag.product = product;
            return View();
        }
        public string Details(string product)
        {
            string message = HttpUtility.HtmlEncode("You selected product:" +product);
            return message;
            
        }
    }
}