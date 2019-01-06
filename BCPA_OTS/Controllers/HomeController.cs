using BCPA_OTS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BCPA_OTS.Controllers
{
    public class HomeController : Controller
    {
        private OTS_Context db = new OTS_Context();

        public ActionResult Index()
        {
            var shows = db.Events.ToList();
            return View(shows);
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
    }
}