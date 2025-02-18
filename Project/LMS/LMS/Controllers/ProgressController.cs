using LMS.Data;
using LMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/progresses")]
public class ProgressController: ControllerBase
{
    private readonly ApplicationDbContext _context;
    public ProgressController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("{userId}/{courseId}")]
    public async Task<ActionResult<List<ProgressDto>>> GetProgresses(int userId, int courseId)
    {
        var progresses = await _context.Progresses
            .Where(p => p.UserID == userId && p.CourseID == courseId)
            .Select(p => new ProgressDto{
                UserID = p.UserID,
                CourseID = p.CourseID,
                LessonID = p.LessonID,
                IsCompleted = p.IsCompleted
            })
            .ToListAsync();
        return Ok(progresses);
    }
}