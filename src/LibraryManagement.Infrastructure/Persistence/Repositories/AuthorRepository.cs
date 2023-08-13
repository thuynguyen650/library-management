using LibraryManagement.Application.Contracts.Persistence;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Infrastructure.Persistence.Repositories;

public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
{
    public AuthorRepository(ApplicationDbContext context) : base(context)
    {
    }
}
