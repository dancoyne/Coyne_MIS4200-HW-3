using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coyne_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Aston Martin Redbull Racing Formula 1 Team";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Dan";

            return View();
        }
    }
}