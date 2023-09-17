using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoomRoostHotel.WEBUI.Dtos.AboutDto;
using RoomRoostHotel.WEBUI.Dtos.RoomDto;

namespace RoomRoostHotel.WEBUI.ViewComponents.Default
{
    public class _OurRoomsPartial:ViewComponent
    {

        readonly private IHttpClientFactory _httpClientFactory;
        public _OurRoomsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();//bir tane istemci oluştur
            var responseMessage = await client.GetAsync("http://localhost:5086/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsondata);
                return View(values);
            }

            return View();
        }
    }
}
