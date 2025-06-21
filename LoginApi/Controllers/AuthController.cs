using Microsoft.AspNetCore.Mvc;
using LoginApi.Data;
using LoginApi.Models;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _context;

    public AuthController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] User login)
    {
        var user = _context.Users.FirstOrDefault(u => u.Username == login.Username && u.Password == login.Password);
        if (user == null)
            return Unauthorized("Invalid credentials");

        return Ok(new { Message = "Login successful", user.Username });
    }
}
