namespace EmployeeAdminPortal.Models.Entities{
    public class Employee{
        public Guid Id{get; set;}
        public required String Name{get; set;}
        public required String Email{get; set;}
        public int? PhoneNumber{get; set;}
        public decimal Salary{get; set;}
    }
}