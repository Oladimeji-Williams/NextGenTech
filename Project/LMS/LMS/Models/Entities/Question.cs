namespace LMS.Models.Entities
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string? QuestionText { get; set; }
        public int QuizID { get; set; }  // Foreign key to Quiz
        public Quiz? Quiz { get; set; }   // Navigation property
        public List<AnswerOption>? AnswerOptions { get; set; }  // List of answer choices
    }


}