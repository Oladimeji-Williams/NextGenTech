namespace LMS.Models.Dtos
{
    public class CourseDto
    {
        public int CourseID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<LessonDto>? Lessons { get; set; }
    }

}