using LibraryManagement.Domain.Common;

namespace LibraryManagement.Domain.Entities;

public class Patron : BaseAuditableEntity
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string CardNumber { get; set; } = string.Empty;

    public bool IsActive { get; set; }

    public List<WaitingList> WaitingLists { get; set; } = new List<WaitingList>();

    public List<Hold> Holds { get; set; } = new List<Hold>();

    public List<Checkout> Checkouts { get; set; } = new List<Checkout>();

    public List<Notification> Notifications { get; set; } = new List<Notification>();
}
