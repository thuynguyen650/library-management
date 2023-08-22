using LibraryManagement.Application.Contracts.Persistence;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Infrastructure.Persistence.Repositories;

public class BookCategoryRepository : GenericRepository<BookCategory>, IBookCategoryRepository
{
    public BookCategoryRepository(ApplicationDbContext context) : base(context)
    {
    }
}
