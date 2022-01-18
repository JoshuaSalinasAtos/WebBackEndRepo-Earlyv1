using System.ComponentModel.DataAnnotations;

namespace WebCourseRepo.Models
{
    public class TopicFeedBackModel : Entity
    {
        [Required]
        public string Feedback { get; set; }

        [Required]
        public int TopicId { get; set; }
    }
}
