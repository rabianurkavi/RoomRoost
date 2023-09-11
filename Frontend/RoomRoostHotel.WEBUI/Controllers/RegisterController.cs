using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RoomRoost.EntityLayer.Concrete;
using RoomRoostHotel.WEBUI.Dtos.RegisterDto;

namespace RoomRoostHotel.WEBUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CreateAppUserDto createAppUser)
        {
            return View();
        }
    }
}
