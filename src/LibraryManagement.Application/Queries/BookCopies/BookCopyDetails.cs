namespace LibraryManagement.Application.Queries.BookCopies;

public record BookCopyDetails
{
    public int YearPublished { get; set; }

    public required string Publisher { get; set; }

    public required Guid PublisherId { get; set; }

    public string? ImageUrl { get; set; }

    public required BookDetails Book { get; set; }
}
