using LibraryManagement.Domain.Entities;
using LibraryManagement.Domain.Entities.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Emit;

namespace LibraryManagement.Infrastructure.Persistence;

public class ApplicationDbContext : 
    IdentityDbContext
    <User,
    Role,
    Guid,
    IdentityUserClaim<Guid>,
    IdentityUserRole<Guid>,
    IdentityUserLogin<Guid>,
    IdentityRoleClaim<Guid>,
    IdentityUserToken<Guid>>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<Book> Books { get; set; }

    public DbSet<Author> Authors { get; set; }

    public DbSet<BookCategory> BookCategories { get; set; }

    public DbSet<BookCopy> BookCopies { get; set; }

    public DbSet<Checkout> Checkouts { get; set; }

    public DbSet<Hold> Holds { get; set; }

    public DbSet<Notification> Notifications { get; set; }

    public override DbSet<User> Users { get; set; }

    public override DbSet<Role> Roles { get; set; }

    public DbSet<Publisher> Publishers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityUserClaim<Guid>>(b =>
        {
            b.ToTable("UserClaims", "authentication");
        });

        builder.Entity<IdentityUserRole<Guid>>(b =>
        {
            b.ToTable("UserRoles", "authentication");
        });

        builder.Entity<IdentityUserLogin<Guid>>(b =>
        {
            b.ToTable("UserLogins", "authentication");
        });

        builder.Entity<IdentityRoleClaim<Guid>>(b =>
        {
            b.ToTable("RoleClaims", "authentication");
        });

        builder.Entity<IdentityUserToken<Guid>>(b =>
        {
            b.ToTable("UserTokens", "authentication");
        });

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
