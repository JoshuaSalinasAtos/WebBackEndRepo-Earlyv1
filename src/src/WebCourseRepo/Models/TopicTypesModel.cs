using System.ComponentModel.DataAnnotations;

namespace WebCourseRepo.Models
{
    public class TopicTypesModel : Entity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
