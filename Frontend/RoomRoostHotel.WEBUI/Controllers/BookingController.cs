using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoomRoostHotel.WEBUI.Dtos.BookingDto;
using RoomRoostHotel.WEBUI.Dtos.ServiceDto;
using RoomRoostHotel.WEBUI.Dtos.SubscribeDto;
using System.Text;

namespace RoomRoostHotel.WEBUI.Controllers
{
    public class BookingController : Controller
    {
        readonly private IHttpClientFactory _httpClientFactory;
        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddBooking()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBooking(CreateBookingDto createBooking)
        {
            createBooking.Description = "dsadsa";
            createBooking.Status = "Onay bekliyor";
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBooking);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsJsonAsync<CreateBookingDto>("http://localhost:5086/api/Booking", createBooking);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
