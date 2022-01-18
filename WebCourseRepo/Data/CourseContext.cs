
using Microsoft.EntityFrameworkCore;
using WebCourseRepo.Models;

namespace WebCourseRepo.Data
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> opt) : base (opt)
        {

        }
        public DbSet<CourseModel> CourseModel { get; set; }

    }
}
