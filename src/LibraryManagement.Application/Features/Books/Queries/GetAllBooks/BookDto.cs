using LibraryManagement.Domain.Entities.Authentication;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Features.Books.Queries.GetAllBooks;

public record BookDto
{
    public required string Title { get; set; }

    public required string ISBN { get; set; }

    public required List<Author> Authors { get; set; }

    public string? Description { get; set; }

    public string? Language { get; set; }

    public long? PageNumber { get; set; }
}
