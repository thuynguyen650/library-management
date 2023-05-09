namespace LibraryManagement.Domain.Entities;

public class Checkout
{
    public Guid BookCopyId { get; set; }

    public BookCopy BookCopy { get; set; } = new BookCopy();

    public Guid PatronId { get; set; }

    public Patron Patron { get; set; } = new Patron();

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public bool IsReturned { get; set; }
}
