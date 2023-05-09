using LibraryManagement.Domain.Common;

namespace LibraryManagement.Domain.Entities;

public class Publisher : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public List<BookCopy> BookCopies { get; set; } = new List<BookCopy>();
}
