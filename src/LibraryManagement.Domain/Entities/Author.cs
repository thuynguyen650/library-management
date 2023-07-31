using LibraryManagement.Domain.Common;

namespace LibraryManagement.Domain.Entities;

public class Author : BaseAuditableEntity
{
    public required string Name { get; set; }
}
