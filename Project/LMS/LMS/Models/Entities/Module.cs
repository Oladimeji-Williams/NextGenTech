namespace LMS.Models.Entities
{
    public class Module
    {
        public int ModuleID {get; set;}
        public string? Title {get; set;}
        public string? Description {get; set;}
        public int CourseID {get; set;}
        public Course? Course {get; set;}
        public List<Lesson>? Lessons {get; set;}
        public List<Quiz>? Quizzes {get; set;}
    }


}