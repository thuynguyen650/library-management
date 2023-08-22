using LibraryManagement.Application.Features.Books.Queries.GetAllBooks;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Contracts.Persistence;

public interface IBookRepository : IGenericRepository<Book>
{
    Task<List<Book>> GetAllBooksAsync();
}
