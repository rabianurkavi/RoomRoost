using Microsoft.AspNetCore.Mvc;

namespace RoomRoostHotel.WEBUI.ViewComponents.Default
{
    public class _TrailerPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
