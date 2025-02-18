namespace LMS.Models
{
    public class EnrollmentDto
    {
        public int UserID { get; set; }
        public int CourseID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName {get; set;}
        public string? CourseTitle { get; set; }
    }

}