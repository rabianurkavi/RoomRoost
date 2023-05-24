using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomRoost.BusinessLayer.Abstract;
using RoomRoost.EntityLayer.Concrete;

namespace RoomRoost.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }
        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
             _staffService.TAdd(staff);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.TGetById(id);
            _staffService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.TUpdate(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values = _staffService.TGetById(id);
            return Ok(values);
        }
    }
}
