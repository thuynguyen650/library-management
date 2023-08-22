using LibraryManagement.Domain.Common;
using LibraryManagement.Domain.Entities.Authentication;

namespace LibraryManagement.Domain.Entities;

public class Book : BaseAuditableEntity
{
    public required string Title { get; set; }

    public required string ISBN { get; set; }

    public string? Description { get; set; }

    public string? Language { get; set; }

    public long? PageNumber { get; set; }

    public List<Keyword> Tags { get; set; } = new List<Keyword>();

    public List<BookCopy> BookCopies { get; set; } = new List<BookCopy>();

    public List<BookCategory> BookCategories { get; set; } = new List<BookCategory>();

    public List<Author> Authors { get; set; } = new List<Author>();

    public List<User>? Users { get; set; }
}
