using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Data;
using StudentRegistration.Models.Entities;
using StudentRegistration.Models;

namespace StudentRegistration.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController: ControllerBase{
        private readonly ApplicationDbContext dbContext;
        public StudentsController(ApplicationDbContext _dbContext){
            dbContext = _dbContext;
        }

        [HttpGet]
        public IActionResult GetAllStudents(){
            return Ok(dbContext.Students.Where(s => !s.IsDeleted).ToList());
        }
        [HttpGet]
        [Route("all-with-deleted")]
        public IActionResult GetAllWithDeletedStudents(){
            return Ok(dbContext.Students.ToList());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetStudentById(Guid id){
            var student = dbContext.Students.Find(id);
            if(student is null){
                return NotFound();
            } else{
                return Ok(student);
            }
        }

        

        [HttpPost]
        public IActionResult AddStudent(AddStudentDto addStudentDto){
            var studentEntity = new Student(){
                FirstName = addStudentDto._FirstName,
                MiddleName = addStudentDto._MiddleName,
                LastName = addStudentDto._LastName,
                DateOfBirth = addStudentDto._DateOfBirth,
                Email = addStudentDto._Email,
                Course = addStudentDto._Course,
                PhoneNumber = addStudentDto._PhoneNumber,
                AdmissionDate = addStudentDto._AdmissionDate
                
            };
            dbContext.Students.Add(studentEntity);
            dbContext.SaveChanges();
            return Ok(studentEntity);
        }

        // [HttpPut]
        // [Route("{id:guid}")]
        // public IActionResult UpdateStudent(Guid id, UpdateStudentDto updateStudentDto){
        //     var studentEntity = dbContext.Students.Find(id);
        //     if(studentEntity is null){
        //         return NotFound();
        //     } else {
        //         studentEntity.FirstName = updateStudentDto.__FirstName;
        //         studentEntity.MiddleName = updateStudentDto.__MiddleName;
        //         studentEntity.LastName = updateStudentDto.__LastName;
        //         studentEntity.DateOfBirth = updateStudentDto.__DateOfBirth;
        //         studentEntity.Email = updateStudentDto.__Email;
        //         studentEntity.Course = updateStudentDto.__Course;
        //         studentEntity.PhoneNumber = updateStudentDto.__PhoneNumber;
        //         studentEntity.AdmissionDate = updateStudentDto.__AdmissionDate;
        //         dbContext.SaveChanges();
        //         return Ok(studentEntity);
        //     }
        // }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateStudent(Guid id, UpdateStudentDto updateStudentDto){
            var studentEntity = dbContext.Students.Find(id);
            if(studentEntity is null){
                return NotFound();
            } else {
                if(!string.IsNullOrWhiteSpace(updateStudentDto.__FirstName)){
                    studentEntity.FirstName = updateStudentDto.__FirstName;
                }
                if(updateStudentDto.__MiddleName is not null){
                    studentEntity.MiddleName = updateStudentDto.__MiddleName;
                }
                if(!string.IsNullOrWhiteSpace(updateStudentDto.__LastName)){
                    studentEntity.LastName = updateStudentDto.__LastName;
                }
                if(updateStudentDto.__DateOfBirth != default){
                    studentEntity.DateOfBirth = updateStudentDto.__DateOfBirth;
                }
                if(!string.IsNullOrWhiteSpace(updateStudentDto.__Email)){
                    studentEntity.Email = updateStudentDto.__Email;
                }
                if(!string.IsNullOrWhiteSpace(updateStudentDto.__Course)){
                    studentEntity.Course = updateStudentDto.__Course;
                }
                if(!string.IsNullOrWhiteSpace(updateStudentDto.__PhoneNumber)){
                    studentEntity.PhoneNumber = updateStudentDto.__PhoneNumber;
                }
                if(updateStudentDto.__AdmissionDate != default){
                    studentEntity.AdmissionDate = updateStudentDto.__AdmissionDate;
                }
                dbContext.SaveChanges();
                return Ok(studentEntity);
            }
        }



        [HttpPut]
        [Route("/soft-delete/{id:guid}")]
        public IActionResult SoftDeleteStudent(Guid id, UpdateStudentDto updateStudentDto){
            var studentEntity = dbContext.Students.Find(id);
            if(studentEntity is null){
                return NotFound();
            } else {
                studentEntity.IsDeleted = true;
                dbContext.SaveChanges();
                return Ok(dbContext.Students.Where(s => !s.IsDeleted).ToList());
            }
        }

        [HttpDelete]
        [Route("hard-delete/{id:guid}")]
        public IActionResult HardDeleteStudent(Guid id){
            var studentEntity = dbContext.Students.Find(id);
            if(studentEntity is null){
                return NotFound();
            } else{
                dbContext.Students.Remove(studentEntity);
                dbContext.SaveChanges();
                return Ok(dbContext.Students);
            }
        }
    }
}