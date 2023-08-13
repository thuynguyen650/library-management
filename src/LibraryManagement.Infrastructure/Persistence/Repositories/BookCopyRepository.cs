using LibraryManagement.Application.Contracts.Persistence;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Infrastructure.Persistence.Repositories;

public class BookCopyRepository : GenericRepository<BookCopy>, IBookCopyRepository
{
    public BookCopyRepository(ApplicationDbContext context) : base(context)
    {
    }
}
