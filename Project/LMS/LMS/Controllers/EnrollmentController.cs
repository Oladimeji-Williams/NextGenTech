using LMS.Data;
using LMS.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/enrollments")]
public class EnrollmentController: ControllerBase
{
    private readonly ApplicationDbContext _context;
    public EnrollmentController(ApplicationDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<List<EnrollmentDto>>> GetEnrollments()
    {
        var enrollments = await _context.Enrollments
            .Include(e => e.User)
            .Include(e => e.Course)
            .Select(e => new EnrollmentDto{
                UserID = e.UserID,
                CourseID = e.CourseID,
                FirstName = e.User.FirstName,
                LastName = e.User.LastName,
                CourseTitle = e.Course.Title
            })
            .ToListAsync();
        return Ok(enrollments);
    }
}