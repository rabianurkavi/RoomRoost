using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoomRoostHotel.WEBUI.Dtos.ServiceDto;
using RoomRoostHotel.WEBUI.Dtos.TestimonialDto;

namespace RoomRoostHotel.WEBUI.ViewComponents.Default
{
    public class _TestimonialPartial:ViewComponent
    {
        readonly private IHttpClientFactory _httpClientFactory;
        public _TestimonialPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();//bir tane istemci oluştur
            var responseMessage = await client.GetAsync("http://localhost:5086/api/Testimonial");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsondata);
                return View(values);
            }

            return View();
        }
    }
}
