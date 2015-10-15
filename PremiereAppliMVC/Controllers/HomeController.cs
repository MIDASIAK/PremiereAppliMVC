using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PremiereAppliMVC.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Gestion d'un centre de formation";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
