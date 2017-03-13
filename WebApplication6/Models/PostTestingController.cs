using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Models
{
    public class PostTestingController : Controller
    {
        // GET: PostTesting
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Foo(string firstName, string lastName, int extraStuff)
        {
            //FirstAndLast fa = new FirstAndLast
            //{
            //    FirstName = firstName,
            //    LastName = lastName
            //};
            //return View(fa);
            return Redirect("/posttesting/index");
        }
    }

    public class FirstAndLast
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}