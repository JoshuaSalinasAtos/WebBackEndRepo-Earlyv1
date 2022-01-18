using System.ComponentModel.DataAnnotations;

namespace WebCourseRepo.Dtos
{
    public class CourseCreateDto
    {
        [Requied]
        [MaxLength(250)]
        public string CourseName { get; set; }

        [Requied]
        public string CourseDescription { get; set; }

        [Requied]
        public double CourseDuration { get; set; }

        [Requied]
        public double CourseRating { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public int CreatedBy { get; set; }

        [Required]
        public DateTime LastUpdatedDate{ get; set;}

        [Requied]
        public int LastUpdatedBy { get; set; }

    }
}
