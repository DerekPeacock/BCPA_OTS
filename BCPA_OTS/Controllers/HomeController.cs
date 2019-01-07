using BCPA_OTS.DAL;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

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


        [HttpGet]
        public ActionResult Show(int id)
        {
            ViewBag.Message = "View the details of a selected event/show!";

            var show = db.Events.Find(id);

            return View(show);
        }

        [HttpGet]
        public ActionResult Book(int id)
        {
            ViewBag.Message = "Book seats for a selected show!";

            var show = db.Shows.Include(s => s.Event)
                .Where(e => e.ShowID == id)
                .FirstOrDefault();

            return View(show);
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