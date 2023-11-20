using Business.Abstract;
using Entity.Concete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _courseService.GetCoursesWithNames2();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost]
        public IActionResult Add(Course course)
        {
            var result = _courseService.Insert(course);
            return result.Success ? Ok() : BadRequest(result);
        }
    }
}
