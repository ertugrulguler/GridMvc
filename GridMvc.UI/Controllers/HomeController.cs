using GridMvc.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridMvc.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Foo> foos = new List<Foo>();

            Foo foo1 = new Foo()
            {
                Title = "deneme",
                Description = "deneme"
            };

            Foo foo2 = new Foo()
            {
                Title = "deneme2",
                Description = "deneme2"
            };

            foos.Add(foo1);
            foos.Add(foo2);

            var items = foos;
            return View(items);
        }
    }
}