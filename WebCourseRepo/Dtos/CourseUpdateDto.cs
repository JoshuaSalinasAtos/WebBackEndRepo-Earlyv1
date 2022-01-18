using System.ComponentModel.DataAnnotations;

namespace WebCourseRepo.Dtos
{
    public class CourseUpdateDto
    {
        [Requied]
        [MaxLength(250)]
        public int Id { get; set; }

        [Requied]
        public string CourseName { get; set; }

        [Requied]
        public string CourseDescription { get; set; }

        [Requied]
        public double CourseDuration { get; set; }
        
        [Requied]
        public double CourseRating { get; set; }

    }
}
