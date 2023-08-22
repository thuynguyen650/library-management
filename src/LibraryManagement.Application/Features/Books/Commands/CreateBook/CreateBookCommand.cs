using MediatR;

namespace LibraryManagement.Application.Features.Books.Commands.CreateBook;

public class CreateBookCommand : IRequest<Guid>
{
    public required string Title { get; set; }

    public required string ISBN { get; set; }

    public string? Description { get; set; }

    public required List<Guid> Authors { get; set; }

    public required List<Guid> Categories { get; set; }

    public int? PageNumber { get; set; }

    public List<string>? Keywords { get; set; }
}
