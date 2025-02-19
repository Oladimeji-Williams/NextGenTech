namespace LMS.Models.Dtos
{
    public class ProgressDto
    {
        public int UserID { get; set; }
        public int CourseID { get; set; }
        public int LessonID { get; set; }
        public bool IsCompleted { get; set; }
    }

}


