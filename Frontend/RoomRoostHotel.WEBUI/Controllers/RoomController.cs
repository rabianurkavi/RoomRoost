using Microsoft.AspNetCore.Mvc;

namespace RoomRoostHotel.WEBUI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
