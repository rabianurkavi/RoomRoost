using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomRoost.BusinessLayer.Abstract;
using RoomRoost.EntityLayer.Concrete;

namespace RoomRoost.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialService.TAdd(testimonial);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _testimonialService.TGetById(id);
            _testimonialService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var values = _testimonialService.TGetById(id);
            return Ok(values);
        }
    }
}
