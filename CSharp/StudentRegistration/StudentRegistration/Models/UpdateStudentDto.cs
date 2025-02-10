namespace StudentRegistration.Models{
    public class UpdateStudentDto{
        public Guid __id {get; set;}
        public required string __FirstName {get; set;}
        public string? __MiddleName {get; set;}
        public required string __LastName {get; set;}
        public required DateOnly __DateOfBirth {get; set;}
        public string? __Course {get; set;}
        public required string __Email {get; set;}
        public string? __PhoneNumber {get; set;}
        public required DateOnly __AdmissionDate {get; set;}

    }
}