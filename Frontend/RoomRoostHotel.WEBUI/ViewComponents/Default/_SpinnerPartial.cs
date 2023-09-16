using Microsoft.AspNetCore.Mvc;

namespace RoomRoostHotel.WEBUI.ViewComponents.Default
{
    public class _SpinnerPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
