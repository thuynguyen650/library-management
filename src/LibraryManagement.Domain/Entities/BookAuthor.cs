using LibraryManagement.Domain.Common;

namespace LibraryManagement.Domain.Entities;

public class BookAuthor
{
    public Guid AuthorId { get; set; }

    public Author Author { get; set; } = new Author();

    public Guid BookId { get; set; }

    public Book Book { get; set; } = new Book();
}
