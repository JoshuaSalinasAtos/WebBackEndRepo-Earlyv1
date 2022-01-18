using WebCourseRepo.Models;

namespace WebCourseRepo.Data
{
    public interface ICourseRepo
    {
        bool SaveChanges();

        Task<List<CourseModel>> GetCourses();
        Task<CourseModel?> GetCourseById(int id);

        void CreateCourse(CourseModel cse);
        void UpdateCourse(CourseModel cse);
        void DeleteCourse(CourseModel cse);
    }
}
