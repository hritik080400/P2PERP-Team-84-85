using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P2PERP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            ViewBag.Message = "Your application description page 2.";
            ViewBag.Message = "Your application description page 2.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void Comment()
        {
            Console.WriteLine("Hello");

        public ActionResult DemoHritik()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
    }
}