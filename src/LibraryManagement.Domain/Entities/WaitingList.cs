using LibraryManagement.Domain.Common;

namespace LibraryManagement.Domain.Entities;

public class WaitingList
{
    public Guid UserId { get; set; }

    public User User { get; set; } = new User();

    public Guid BookId { get; set; }

    public Book Book { get; set; } = new Book();
}
