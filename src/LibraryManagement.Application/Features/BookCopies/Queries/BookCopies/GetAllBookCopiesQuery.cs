using MediatR;

namespace LibraryManagement.Application.Features.BookCopies.Queries.BookCopies;

public record GetAllBookCopiesQuery : IRequest<List<BookCopyDetails>>
{
}
