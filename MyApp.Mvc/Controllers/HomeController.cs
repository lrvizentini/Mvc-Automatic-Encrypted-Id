using MvcHelpers.Types;
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

            int id1 = 110;
            long id2 = 23304;

            model.IntIdTest = id1;
            model.LongIdTest = id2;

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(IndexViewModel model)
        {
            model.IntIdTest = (10 + model.IntIdTest);

            return View(model);
        }

        public JsonResult GetIntValueFromEncrypted(EncryptedInt id)
        {
            int intValue = id;

            return Json(intValue, JsonRequestBehavior.AllowGet);
        }

    }
}