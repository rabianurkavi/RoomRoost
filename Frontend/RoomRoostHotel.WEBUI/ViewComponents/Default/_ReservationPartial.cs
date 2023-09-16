using Microsoft.AspNetCore.Mvc;

namespace RoomRoostHotel.WEBUI.ViewComponents.Default
{
    public class _ReservationPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
