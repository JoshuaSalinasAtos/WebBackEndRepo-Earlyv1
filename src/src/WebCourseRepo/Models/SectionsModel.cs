using System.ComponentModel.DataAnnotations;

namespace WebCourseRepo.Models
{
    public class SectionsModel : Entity
    {
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string? Description { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public double? Rating { get; set; }

        [Required]
        public byte[]? Data { get; set; }
    }
}
