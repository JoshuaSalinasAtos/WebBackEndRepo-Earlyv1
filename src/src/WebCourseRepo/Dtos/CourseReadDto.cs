namespace WebCourseRepo.Dtos
{
    public class CourseReadDto
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public string CourseDescription { get; set; }

        public double CourseDuration { get; set; }

        public double CourseRating { get; set; }
        public DateTime CreatedDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public int LastUpdatedBy { get; set; }

    }
}
