namespace LibraryManagement.Domain.Common;

public class BaseAuditableEntity : BaseEntity
{
    public DateTime Created { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime Updated { get; set; }

    public Guid UpdatedBy { get; set; }
}
