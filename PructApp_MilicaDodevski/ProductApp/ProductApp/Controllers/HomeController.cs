using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductApp.Controllers
{
    public class HomeController : Controller
    {
        //Vraca pocetnu stranicu
        public ActionResult Index()
        {
            return View();
        }
        //Vraca stranicu o nama

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //Vraca kontant stranicu

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}