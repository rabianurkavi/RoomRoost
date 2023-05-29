using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoomRoostHotel.WEBUI.Models.Staff;
using RoomRoostHotel.WEBUI.Models.Testimonial;
using System.Text;

namespace RoomRoostHotel.WEBUI.Controllers
{
    public class TestimonialController : Controller
    {
        readonly private IHttpClientFactory _httpClientFactory;
        public TestimonialController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();//bir tane istemci oluştur
            //istemci aracılığıyla, belirtilen URI'ye bir GET isteği gönderilir
            var responseMessage = await client.GetAsync("http://localhost:5086/api/Testimonial");
            //eğer başarılı bir kod dönerse
            if (responseMessage.IsSuccessStatusCode)
            {
                //responseMessage.Content.ReadAsStringAsync() koduyla yanıtın içeriği asenkron olarak okunur ve jsondata değişkenine
                //atanır. Bu içerik, genellikle bir JSON verisi olarak gelir.
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                //dönüştürme işlemi
                //JsonConvert.DeserializeObject<List<StaffViewModel>>(jsondata) ifadesi, jsondata içeriğini List<StaffViewModel>
                //türünde bir nesneye dönüştürür. Bu dönüşüm, JSON verisini C# nesnelerine uygun şekilde ayrıştırır.
                var values = JsonConvert.DeserializeObject<List<TestimonialViewModel>>(jsondata);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddTestimonial(AddTestimonialViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5086/api/Testimonial", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5086/api/Testimonial/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5086/api/Testimonial/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateTestimonialViewModel>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5086/api/Testimonial/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();
        }

    }
}
