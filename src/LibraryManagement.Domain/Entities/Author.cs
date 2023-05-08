using LibraryManagement.Domain.Common;

namespace LibraryManagement.Domain.Entities;

public class Author : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public List<BookAuthor> BookAuthorList { get; set; } = new List<BookAuthor>();
}
