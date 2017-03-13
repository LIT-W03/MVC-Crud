using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Data;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string categoryName, int? minStock)
        {
            NorthwindDb db = new NorthwindDb(Properties.Settings.Default.ConStr);
            IEnumerable<Product> products = db.Search(categoryName, minStock);
            HomePageViewModel vm = new HomePageViewModel();
            vm.Products = products;
            vm.CategoryName = categoryName;
            vm.MinUnitsInStock = minStock;
            return View(vm);
        }
    }
}