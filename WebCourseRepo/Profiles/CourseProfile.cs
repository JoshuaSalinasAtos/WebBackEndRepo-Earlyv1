using AutoMapper;
using WebCourseRepo.Dtos;
using WebCourseRepo.Models;

namespace WebCourseRepo.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            //source -> Target
            CreateMap<CourseModel, CourseReadDto>();
            CreateMap<CourseCreateDto, CourseModel>();
            CreateMap<CourseUpdateDto, CourseModel>();
            CreateMap<CourseModel, CourseUpdateDto>();

        }
    }
}
