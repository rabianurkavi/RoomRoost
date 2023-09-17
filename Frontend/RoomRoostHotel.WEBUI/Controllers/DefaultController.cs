using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoomRoost.EntityLayer.Concrete;
using RoomRoostHotel.WEBUI.Dtos.RegisterDto;
using RoomRoostHotel.WEBUI.Dtos.ServiceDto;
using RoomRoostHotel.WEBUI.Dtos.SubscribeDto;
using System.Text;

namespace RoomRoostHotel.WEBUI.Controllers
{
    public class DefaultController : Controller
    {
        readonly private IHttpClientFactory _httpClientFactory;
        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult _SubscribePartial()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> _SubscribePartial(CreateSubscribeDto createSubscribeDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSubscribeDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:3523/api/Subscribe", stringContent);
            return RedirectToAction("Index", "Default");
        }
    }
}
