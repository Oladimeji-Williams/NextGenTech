namespace LMS.Models.Entities
{
    public class Lesson
    {
        public int LessonID {get; set;}
        public string? Title {get; set;}
        public int CourseID {get; set;}
        public Course? Course {get; set;}
        public List<Progress>? Progresses {get; set;}
    }
}