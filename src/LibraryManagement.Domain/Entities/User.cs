using LibraryManagement.Domain.Common;

namespace LibraryManagement.Domain.Entities;

public class User : BaseAuditableEntity
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public bool IsActive { get; set; }

    public string PasswordHash { get; set; } = string.Empty;

    //public List<UserBook> Books { get; set; } = new List<UserBook>();

    public List<Hold> Holds { get; set; } = new List<Hold>();

    public List<Checkout> Checkouts { get; set; } = new List<Checkout>();

    public List<Notification> Notifications { get; set; } = new List<Notification>();

    public List<Book> Books { get; set; } = new List<Book>();
}
