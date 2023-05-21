using LibraryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LibraryManagement.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<Book> Books { get; set; }

    public DbSet<Author> Authors { get; set; }

    public DbSet<BookAuthor> BookAuthors { get; set; }

    public DbSet<BookCategory> BookCategories { get; set; }

    public DbSet<BookCopy> BookCopies { get; set; }

    public DbSet<Checkout> Checkouts { get; set; }

    public DbSet<Hold> Holds { get; set; }

    public DbSet<Notification> Notifications { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<Publisher> Publishers { get; set; }

    public DbSet<WaitingList> WaitingLists { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
}
