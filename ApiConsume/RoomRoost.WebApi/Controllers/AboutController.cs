using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RoomRoost.BusinessLayer.Abstract;
using RoomRoost.EntityLayer.Concrete;

namespace AboutRoost.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        readonly private IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values=_aboutService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAbout(About About)
        {
            _aboutService.TAdd(About);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            _aboutService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout(About About)
        {
            _aboutService.TUpdate(About);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _aboutService.TGetById(id);
            return Ok(values);
        }
    }
}
