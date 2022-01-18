using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebCourseRepo.Data;
using WebCourseRepo.Models;

namespace WebCourseRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController :ControllerBase
    {
        private readonly ICourseRepo  _repositoryCourse;
        private readonly IMapper _mapper;

        public CourseController(ICourseRepo repository, IMapper mapper)
        {
            _repositoryCourse = repository;
            _mapper = mapper;
        }
        //Get: api/Course
        [HttpGet]
        public async Task<IActionResult> GetCourses()
        {
            List<CourseModel> cse = await _repositoryCourse.GetCourses();
            return Ok("hey"+cse);
        }
        //Get api/Course/Id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCoursesById(int id)
        {
            CourseModel? cseDto = await _repositoryCourse.GetCourseById(id);
            return cseDto !=null ? Ok(cseDto) : NotFound();
        }
    }
}
