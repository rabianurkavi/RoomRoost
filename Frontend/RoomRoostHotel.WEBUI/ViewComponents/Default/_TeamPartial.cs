using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoomRoostHotel.WEBUI.Dtos.ServiceDto;
using RoomRoostHotel.WEBUI.Dtos.StaffDto;

namespace RoomRoostHotel.WEBUI.ViewComponents.Default
{
    public class _TeamPartial:ViewComponent
    {
        readonly private IHttpClientFactory _httpClientFactory;
        public _TeamPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();//bir tane istemci oluştur
            var responseMessage = await client.GetAsync("http://localhost:5086/api/Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultStaffDto>>(jsondata);
                return View(values);
            }

            return View();
        }
    }
}
