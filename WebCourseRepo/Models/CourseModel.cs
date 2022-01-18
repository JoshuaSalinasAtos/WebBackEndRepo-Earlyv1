using System.ComponentModel.DataAnnotations;

namespace WebCourseRepo.Models
{
    public class CourseModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string CourseName { get; set; }

        [Required]
        public string Description { get; set; } 

        [Required]
        public double Duration { get; set; }    
        
        [Required]
        public double Rating { get; set; }
    }
}
