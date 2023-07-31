using MediatR;

namespace LibraryManagement.Application.Queries.BookCopies;

public record GetAllBookCopiesQuery : IRequest<List<BookCopyDetails>>
{
}
