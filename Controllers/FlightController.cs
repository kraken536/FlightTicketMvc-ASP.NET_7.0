using Microsoft.AspNetCore.Mvc;

namespace FlightTicketsReservationMVC.Controllers
{
    public class FlightController : Controller
    {
        public IActionResult SeatDetails()
        {
            return View();
        }
    }
}
