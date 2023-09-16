using Microsoft.AspNetCore.Mvc;

namespace RoomRoostHotel.WEBUI.ViewComponents.Default
{
    public class _HeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
