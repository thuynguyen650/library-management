using LibraryManagement.Domain.Common;

namespace LibraryManagement.Domain.Entities;

public class BookCopy : BaseAuditableEntity
{
    public Guid BookId { get; set; }

    public Book Book { get; set; } = new Book();
}
