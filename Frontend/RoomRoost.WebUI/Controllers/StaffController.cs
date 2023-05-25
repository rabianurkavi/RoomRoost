using Microsoft.AspNetCore.Mvc;

namespace RoomRoost.WebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
