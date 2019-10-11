using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Hotel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public JsonResult ajaxtest()
        { JsonResult result = new JsonResult();
            result.Data = new { name = "DNZ", AGE = 29 };
            result.JsonRequestBehavior =JsonRequestBehavior.AllowGet;
            return result;

        }
    }
}