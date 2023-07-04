namespace LibraryManagement.Application.Queries.BookCopies;

public record AuthorDetails
{
    public Guid Id { get; set; }

    public required string Name { get; set; }
}
