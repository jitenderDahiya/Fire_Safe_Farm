using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace New_UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndiMap()
        {
            ViewBag.Message = "Indicator and Map";


            return View();
        }

        public ActionResult Animation()
        {
            ViewBag.Message = "Guideline animation";


            return View();
        }

        public ActionResult Permit()
        {
            ViewBag.Message = "permit";

            return View();
        }

        public ActionResult Burnoff()
        {
            ViewBag.Message = "Burnoff";

            return View();
        }

        public ActionResult Schedule13()
        {
            ViewBag.Message = "Schedule13";

            return View();
        }

        public ActionResult Schedule14()
        {
            ViewBag.Message = "Schedule14";

            return View();
        }

        public ActionResult Schedule40()
        {
            ViewBag.Message = "Schedule40";

            return View();
        }
        public ActionResult Recovery()
        {
            ViewBag.Message = "Recovery";

            return View();
        }


    }
}