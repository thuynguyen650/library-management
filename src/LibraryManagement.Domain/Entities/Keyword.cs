using LibraryManagement.Domain.Common;

namespace LibraryManagement.Domain.Entities;

public class Keyword : BaseAuditableEntity
{
    public required string Word { get; set; }
}
