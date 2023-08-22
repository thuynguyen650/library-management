using LibraryManagement.Application.Contracts.Persistence;
using LibraryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure.Persistence.Repositories;

public class BookRepository : GenericRepository<Book>, IBookRepository
{
    public BookRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<List<Book>> GetAllBooksAsync()
    {
        return await _context.Books
            .Include(b => b.Authors)
            .ToListAsync();
    }
}
