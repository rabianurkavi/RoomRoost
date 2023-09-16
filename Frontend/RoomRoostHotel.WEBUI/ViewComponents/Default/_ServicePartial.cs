using Microsoft.AspNetCore.Mvc;

namespace RoomRoostHotel.WEBUI.ViewComponents.Default
{
    public class _ServicePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
