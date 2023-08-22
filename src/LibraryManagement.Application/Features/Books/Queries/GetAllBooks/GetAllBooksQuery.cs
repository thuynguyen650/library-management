using MediatR;

namespace LibraryManagement.Application.Features.Books.Queries.GetAllBooks;

public class GetAllBooksQuery : IRequest<List<BookDto>>
{
}
