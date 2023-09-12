using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RoomRoost.EntityLayer.Concrete;
using RoomRoostHotel.WEBUI.Dtos.RegisterDto;

namespace RoomRoostHotel.WEBUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateAppUserDto createAppUserDto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                Name = createAppUserDto.Name,
                SurName = createAppUserDto.SurName,
                Email = createAppUserDto.Email,
                UserName = createAppUserDto.UserName,
            };
            var result = await _userManager.CreateAsync(appUser, createAppUserDto.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
