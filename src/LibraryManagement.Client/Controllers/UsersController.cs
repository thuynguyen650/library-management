using LibraryManagement.Domain.Entities.Authentication;
using LibraryManagement.Infrastructure.Persistence;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Client.Controllers;

public class UsersController : ApiControllerBase
{
    private ApplicationDbContext _context;

    public UsersController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [EnableCors("OpenCORSPolicy")]
    public async Task<ActionResult<List<User>>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }
}
