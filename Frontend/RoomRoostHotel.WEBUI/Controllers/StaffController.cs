using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoomRoostHotel.WEBUI.Models.Staff;

namespace RoomRoostHotel.WEBUI.Controllers
{
    public class StaffController : Controller
    {
        readonly private IHttpClientFactory _httpClientFactory;
        public StaffController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();//bir tane istemci oluştur
            //istemci aracılığıyla, belirtilen URI'ye bir GET isteği gönderilir
            var responseMessage = await client.GetAsync("http://localhost:5086/api/Staff");
            //eğer başarılı bir kod dönerse
            if (responseMessage.IsSuccessStatusCode)
            {
                //responseMessage.Content.ReadAsStringAsync() koduyla yanıtın içeriği asenkron olarak okunur ve jsondata değişkenine
                //atanır. Bu içerik, genellikle bir JSON verisi olarak gelir.
                var jsondata =await responseMessage.Content.ReadAsStringAsync();
                //dönüştürme işlemi
                //JsonConvert.DeserializeObject<List<StaffViewModel>>(jsondata) ifadesi, jsondata içeriğini List<StaffViewModel>
                //türünde bir nesneye dönüştürür. Bu dönüşüm, JSON verisini C# nesnelerine uygun şekilde ayrıştırır.
                var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(jsondata);
                return View(values);
            }
            return View();
        }
    }
}
