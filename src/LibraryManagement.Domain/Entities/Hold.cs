using LibraryManagement.Domain.Common;
using LibraryManagement.Domain.Entities.Authentication;

namespace LibraryManagement.Domain.Entities;

public class Hold
{
    public Guid BookCopyId { get; set; }

    public required BookCopy BookCopy { get; set; }

    public Guid UserId { get; set; }

    public User User { get; set; } = new User();

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}
