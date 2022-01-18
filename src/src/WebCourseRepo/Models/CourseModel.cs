using System.ComponentModel.DataAnnotations;

namespace WebCourseRepo.Models
{
    public class CourseModel : Entity
    {
        
        [Required]
        [StringLength(250)]
        public string? CourseName { get; set; }

        [Required]
        public string? Description { get; set; } 

        [Required]
        public double Duration { get; set; }    
        
        [Required]
        public double Rating { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required]
        public int CreatedBy { get; set; }

        [Required]
        public DateTime LastUpdatedDate { get; set; }

        [Required]
        public int UpdatedBy { get; set; }

        [Required]
        public int Status { get; set; }

    }
}
