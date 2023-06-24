using LibraryManagement.Domain.Common;
using LibraryManagement.Domain.Entities.Authentication;
using LibraryManagement.Domain.Enums;

namespace LibraryManagement.Domain.Entities;

public class Notification
{
    public NotificationType NotificationType { get; set; }

    public Guid UserId { get; set; }

    public User User { get; set; } = new User();

    public Guid BookCopyId { get; set; }

    public BookCopy BookCopy { get; set; } = new BookCopy();
}
