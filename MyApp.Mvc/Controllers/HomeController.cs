using MyApp.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp.Mvc.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var model = new IndexViewModel();

            int id1 = 100;
            long id2 = 23304;

            model.IdTest1 = id1;
            model.IdTest2 = id2;

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            return View();
        }
    }
}