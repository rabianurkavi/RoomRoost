using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomRoost.BusinessLayer.Abstract;
using RoomRoost.EntityLayer.Concrete;

namespace RoomRoost.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        readonly private IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            _roomService.TGetAll();
            return Ok();
        }
        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomService.TAdd(room);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var value = _roomService.TGetById(id);
            _roomService.TDelete(value);
            return Ok();    
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _roomService.TUpdate(room);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var values= _roomService.TGetById(id);
            return Ok(values);
        }
    }
}
