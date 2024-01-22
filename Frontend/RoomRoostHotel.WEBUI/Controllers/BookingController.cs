using Microsoft.AspNetCore.Mvc;

namespace RoomRoostHotel.WEBUI.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
