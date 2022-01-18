using WebCourseRepo.Models;

namespace WebCourseRepo.Data
{
    public class MockCourseRepo :ICourseRepo
    {
        private readonly CourseContext _entityContext;

        public MockCourseRepo(CourseContext entityContext)
        {
            _entityContext = entityContext;
        }
        public void CreateCourse(CourseModel cse)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse(CourseModel cse)
        {
            throw new NotImplementedException();
        }

        public Task<CourseModel?> GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseModel>> GetCourses()
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(CourseModel cse)
        {
            throw new NotImplementedException();
        }
    }
}
