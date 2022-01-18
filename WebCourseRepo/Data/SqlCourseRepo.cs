using Microsoft.EntityFrameworkCore;
using WebCourseRepo.Models;

namespace WebCourseRepo.Data
{
    public class SqlCourseRepo : ICourseRepo
    {
        private readonly CourseContext _courseContext;

        public SqlCourseRepo(CourseContext courseContext)
        {
            _courseContext = courseContext;
        }

        public void CreateCourse(CourseModel cse)
        {
            if(cse == null)
            {
                throw new ArgumentNullException(nameof(cse));
            }
            _courseContext.Add(cse);
        }
        public void DeleteCourse(CourseModel cse)
        {
            if (cse == null)
            {
                throw new ArgumentNullException(nameof(cse));
            }
            _courseContext.CourseModel.Remove(cse);
        }
        public bool SaveChanges()
        {
            return (_courseContext.SaveChanges() >= 0);
        }
        public void UpdateCourse(CourseModel cse)
        {
            //Not yet buddy...
        }

        public async Task<List<CourseModel>> GetUsers()
        {
            return await _courseContext.CourseModel.ToListAsync();
        }

        public async Task<CourseModel> GetCourseById(int id)
        {
            return await _courseContext.CourseModel.FindAsync(id);
        }
    }

    
}
