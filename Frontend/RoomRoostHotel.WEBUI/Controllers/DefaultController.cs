using Microsoft.AspNetCore.Mvc;

namespace RoomRoostHotel.WEBUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
