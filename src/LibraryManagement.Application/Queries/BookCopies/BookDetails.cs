namespace LibraryManagement.Application.Queries.BookCopies;

public record class BookDetails
{
    public required string Title { get; set; }

    public required string BookCategory { get; set; }

    public required string BookCategoryId { get; set; }

    public List<AuthorDetails> Authors { get; set; } = new List<AuthorDetails>();

    public List<BookCopyDetails> BookCopies { get; set; } = new List<BookCopyDetails>();
}
