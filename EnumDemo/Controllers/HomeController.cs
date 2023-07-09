using EnumDemo.Models;
using System.Web.Mvc;

namespace EnumDemo.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Appointment() {
            return View(new AppointmentModel());
        }

        public ActionResult Submit(AppointmentModel appointment) {
            return View(appointment);
        }
    }
}