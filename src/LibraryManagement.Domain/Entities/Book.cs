using LibraryManagement.Domain.Common;

namespace LibraryManagement.Domain.Entities;

public class Book : BaseAuditableEntity
{
    public string Title { get; set; } = string.Empty;

    public List<BookCopy> BookCopies { get; set; } = new List<BookCopy>();

    public Guid BookCategoryId { get; set; }

    public BookCategory BookCategory { get; set; } = new BookCategory();

    public List<BookAuthor> BookAuthorList { get; set; } = new List<BookAuthor>();

    public List<WaitingList> WaitingList { get; set; } = new List<WaitingList>();
}
