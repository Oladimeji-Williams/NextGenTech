namespace LMS.Models.Entities
    {
    public class Progress
    {
        public int ProgressID {get; set;}
        public int UserID {get; set;}
        public User? User {get; set;} // Added User navigation
        public int CourseID {get; set;}
        public Course? Course {get; set;} // Added Course navigation
        public int LessonID {get; set;}
        public Lesson? Lesson {get; set;} // Added Lesson navigation
        public bool IsCompleted {get; set;}
        public DateTime? CompletedAt {get; set;}
    }

}