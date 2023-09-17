using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoomRoostHotel.WEBUI.Dtos.AboutDto;
using RoomRoostHotel.WEBUI.Dtos.RoomDto;
using RoomRoostHotel.WEBUI.Dtos.ServiceDto;

namespace RoomRoostHotel.WEBUI.ViewComponents.Default
{
    public class _AboutUsPartial:ViewComponent
    {
        readonly private IHttpClientFactory _httpClientFactory;
        public _AboutUsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();//bir tane istemci oluştur
            var responseMessage = await client.GetAsync("http://localhost:5086/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {              
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsondata);
                return View(values);
            }
        
            return View();
        }

    }
}
