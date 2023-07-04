using MediatR;

namespace LibraryManagement.Application.Queries.BookCopies;

public record GetAllBooksQuery : IRequest<List<BookDetails>>
{
}
