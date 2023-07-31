namespace LibraryManagement.Application.Queries.BookCopies;

public record class BookDetails
{
    public required string Title { get; set; }

    public required string BookCategory { get; set; }

    public List<AuthorDetails> Authors { get; set; } = new List<AuthorDetails>();
}
