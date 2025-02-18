namespace LMS.Models.Entities
{
    public class User
    {
        public int UserID {get; set;}
        public string? FirstName {get; set;}
        public string? LastName {get; set;}
        public string? Email {get; set;}
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public List<Enrollment>? Enrollments {get; set;}
        public List<Course>? Courses {get; set;} // Added Courses navigation
    }

}