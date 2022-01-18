using System.ComponentModel.DataAnnotations;

namespace WebCourseRepo.Models
{
    public class TagsModel : Entity
    {
        
        [Required]
        [StringLength(50)]
        public string TagName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Popularity { get; set; }

        [Required]
        public int Status { get; set; }
    }
}
