using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers{
    //localhost:xxxx/api/employees
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController: ControllerBase{
        private readonly ApplicationDbContext _dbContext;
        public EmployeesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllEmployees(){
            return Ok(_dbContext.Employees.ToList());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployeeId(Guid id){
            var employee = _dbContext.Employees.Find(id);
            if (employee is null){
                return NotFound();
            } else{
                return Ok(employee);
            }

        }

        [HttpPost]  
        public IActionResult AddEmployees(AddEmployeesDto addEmployeesDto){
            var employeeEntity = new Employee(){
                Name = addEmployeesDto.Name,
                Email = addEmployeesDto.Email,
                PhoneNumber = addEmployeesDto.PhoneNumber,
                Salary = addEmployeesDto.Salary
            };
            _dbContext.Employees.Add(employeeEntity);
            _dbContext.SaveChanges();
            return Ok(employeeEntity);
        }
        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto){
            var employee = _dbContext.Employees.Find(id);
            if(employee is null){
                return NotFound();
            } else{
                employee.Name = updateEmployeeDto.Name;
                employee.Email = updateEmployeeDto.Email;
                employee.PhoneNumber = updateEmployeeDto.PhoneNumber;
                employee.Salary = updateEmployeeDto.Salary;
                _dbContext.SaveChanges();
                return Ok(employee);
            }
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id){
            var employee = _dbContext.Employees.Find(id);
            if(employee is null){
                return NotFound();
            } else{
                _dbContext.Employees.Remove(employee);
                _dbContext.SaveChanges();
                return Ok();
            }
        }
    }
    
}