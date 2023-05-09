using LibraryManagement.Domain.Common;

namespace LibraryManagement.Domain.Entities;

public class WaitingList
{
    public Guid PatronId { get; set; }

    public Patron Patron { get; set; } = new Patron();

    public Guid BookId { get; set; }

    public Book Book { get; set; } = new Book();
}
