using LibraryManagement.Domain.Common;
using LibraryManagement.Domain.Enums;

namespace LibraryManagement.Domain.Entities;

public class Notification
{
    public NotificationType NotificationType { get; set; }

    public Guid PatronId { get; set; }

    public Patron Patron { get; set; } = new Patron();

    public Guid BookCopyId { get; set; }

    public BookCopy BookCopy { get; set; } = new BookCopy();
}
