namespace StudentRegistration.Models{
    public class AddStudentDto{
        public Guid _id{get; set;}
        public required string _FirstName{get; set;}
        public string? _MiddleName{get; set;}
        public required string _LastName{get; set;}
        public required DateOnly _DateOfBirth{get; set;}
        public required string _Course{get; set;}
        public string? _Email{get; set;}
        public string? _PhoneNumber{get; set;}
        public DateOnly _AdmissionDate{get; set;}
    }
}