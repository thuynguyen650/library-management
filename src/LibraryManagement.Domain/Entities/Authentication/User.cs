using Microsoft.AspNetCore.Identity;

namespace LibraryManagement.Domain.Entities.Authentication;

public class User : IdentityUser<Guid>
{
    public List<Book> Books { get; set; } = new List<Book>();
}
