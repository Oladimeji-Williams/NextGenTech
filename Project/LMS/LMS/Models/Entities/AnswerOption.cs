namespace LMS.Models.Entities
{

    public class AnswerOption
    {
        public int AnswerOptionID { get; set; }
        public string? OptionText { get; set; }
        public bool IsCorrect { get; set; }  // Indicate if this is the correct answer
        public int QuestionID { get; set; }  // Foreign key to Question
        public Question? Question { get; set; } // Navigation property
    }


}