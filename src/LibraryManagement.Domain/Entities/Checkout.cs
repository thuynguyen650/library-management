using LibraryManagement.Domain.Entities.Authentication;

namespace LibraryManagement.Domain.Entities;

public class Checkout
{
    public Guid BookCopyId { get; set; }

    public BookCopy BookCopy { get; set; } = new BookCopy();

    public Guid UserId { get; set; }

    public User User { get; set; } = new User();

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public bool IsReturned { get; set; }
}
