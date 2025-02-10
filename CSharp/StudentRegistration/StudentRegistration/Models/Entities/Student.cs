namespace StudentRegistration.Models.Entities{
    public class Student{
        public Guid id{get; set;}
        public required string FirstName{get; set;}
        public string? MiddleName{get; set;}
        public required string LastName{get; set;}
        public required DateOnly DateOfBirth{get; set;}
        public required string Course{get; set;}
        public string? Email{get; set;}
        public string? PhoneNumber{get; set;}
        public required DateOnly AdmissionDate{get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
        public DateTime ModifiedAt{get; set;} = DateTime.UtcNow;
        public bool IsDeleted {get; set;} = false;

    }
}