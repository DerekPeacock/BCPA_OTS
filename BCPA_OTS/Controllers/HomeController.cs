using BCPA_OTS.DAL;
using BCPA_OTS.Models;
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

            Promotion promotion = new Promotion();

            var show = db.Shows
                .Include(s => s.Event)
                .Where(e => e.ShowID == id)
                .FirstOrDefault();

            show.Promotion = promotion;

            return View(show);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Book([Bind(Include = "SeatID,RowNo,SeatNo,SeatType,ShowID,Status")] Seat seat)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(seat).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Book");
        //    }
        //    return RedirectToAction("Book");
        //}


        public ActionResult BookSeat(int showID, int seatID)
        {
            Seat seat = db.Seats.Find(seatID);

            if (seat.Status == SeatStatus.Available)
            {
                seat.Status = SeatStatus.Hold;
            }
            else if(seat.Status == SeatStatus.Hold)
            {
                seat.Status = SeatStatus.Available;
            }

            if (ModelState.IsValid)
            {
                db.Entry(seat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Book", new { id = showID });
            }

            return RedirectToAction("Book", new { id = showID });
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