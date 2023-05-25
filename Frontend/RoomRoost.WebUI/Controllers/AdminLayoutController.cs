using Microsoft.AspNetCore.Mvc;

namespace RoomRoost.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }
    }
}
