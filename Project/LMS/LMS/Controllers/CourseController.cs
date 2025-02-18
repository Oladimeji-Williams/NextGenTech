using LMS.Data;
using LMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/courses")]
public class CourseController: ControllerBase
{
    private readonly ApplicationDbContext _context;
    public CourseController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<CourseDto>>> GetCourses()
    {
        var courses = await _context.Courses
            .Include(c => c.Lessons)
            .ToListAsync();

        var courseDtos = courses.Select(course =>  new CourseDto{
            CourseID = course.CourseID,
            Title = course.Title,
            Description = course.Description,
            Lessons = course.Lessons.Select(lesson => new LessonDto{
                LessonID = lesson.LessonID,
                Title = lesson.Title
            })
            .ToList()
        })
        .ToList();
        return Ok(courseDtos);
    }
}