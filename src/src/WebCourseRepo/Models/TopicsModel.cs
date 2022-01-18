using System.ComponentModel.DataAnnotations;

namespace WebCourseRepo.Models
{
    public class TopicsModel : Entity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int? Number { get; set; }

        [Required]
        public double? Rating { get; set; }

        [Required]
        public byte[] Deleted { get; set; }

        [Required]
        public int SectionId { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Required]
        public int TypeId { get; set; }
    }
}
