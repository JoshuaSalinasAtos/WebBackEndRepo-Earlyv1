using System.ComponentModel.DataAnnotations;

namespace WebCourseRepo.Models
{
    public class CoursesTagsModel : Entity
    {
        [Required]
        public int CourseId { get; set; }  
        
        [Required]
        public int TagId { get; set; }
    }
}
