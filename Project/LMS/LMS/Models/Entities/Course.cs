namespace LMS.Models.Entities
{
    public class Course
    {
        public int CourseID {get; set;}
        public string? Title {get; set;}
        public string? Description {get; set;}
        public List<Lesson>? Lessons {get; set;}
        public List<Enrollment>? Enrollments {get; set;}
        public List<Module>? Modules {get; set;} // Added Modules
        public List<Quiz>? Quizzes {get; set;} // Added Quizzes
    }

}