using LibraryManagement.Domain.Common;
using LibraryManagement.Domain.Entities.Authentication;

namespace LibraryManagement.Domain.Entities;

public class Book : BaseAuditableEntity
{
    public string Title { get; set; } = string.Empty;

    public List<BookCopy> BookCopies { get; set; } = new List<BookCopy>();

    public Guid BookCategoryId { get; set; }

    public BookCategory BookCategory { get; set; } = new BookCategory();

    public List<Author> Authors { get; set; } = new List<Author>();

    public List<User> Users { get; set; } = new List<User>();
}
