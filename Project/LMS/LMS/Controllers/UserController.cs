using LMS.Data;
using LMS.Models;
using LMS.Utilities;
using LMS.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/users")]

public class UserController: ControllerBase
{
    private readonly ApplicationDbContext _context;
    public UserController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<UserDto>>> GetUsers()
    {
        var users = await _context.Users.Select(user => new UserDto{
            UserID = user.UserID,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email
        })
        .ToListAsync();
        return Ok(users);
    }


    [HttpPost("signup")]
    public async Task<IActionResult> SignUp(UserDto request)
    {
        // Check if user exists
        if (_context.Users.Any(u => u.Email == request.Email))
            return BadRequest("User already exists.");

        // Hash password
        PasswordHelper.CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

        var user = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            PasswordHash = passwordHash,
            PasswordSalt = passwordSalt
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        
        return Ok("User registered successfully!");
    }


    [HttpPost("signin")]
    public async Task<IActionResult> SignIn(UserLoginDto request)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
        
        if (user == null) 
            return BadRequest("User not found.");

        // Verify password
        if (!PasswordHelper.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            return BadRequest("Incorrect password.");

        return Ok("Login successful!");
    }



}

