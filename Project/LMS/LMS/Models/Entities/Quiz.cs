namespace LMS.Models.Entities
{
    public class Quiz
    {
        public int QuizID {get; set;}
        public string? QuizTitle {get; set;}
        public int ModuleID {get; set;}
        public Module? Module {get; set;}
        public List<Question>? Questions {get; set;}
    }


}