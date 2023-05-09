using LibraryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.Infrastructure.Persistence.EntitiesConfiguration;

public class BookCopyCofiguration : IEntityTypeConfiguration<BookCopy>
{
    public void Configure(EntityTypeBuilder<BookCopy> builder)
    {
        builder.HasKey(bookCopy => bookCopy.Id);

        builder.HasMany(bookCopy => bookCopy.Holds)
            .WithOne(hold => hold.BookCopy)
            .HasForeignKey(hold => hold.BookCopyId);

        builder.HasMany(bookCopy => bookCopy.Checkouts)
            .WithOne(checkout => checkout.BookCopy)
            .HasForeignKey(checkout => checkout.BookCopyId);

        builder.HasMany(bookCopy => bookCopy.Notifications)
            .WithOne(notification => notification.BookCopy)
            .HasForeignKey(notification => notification.BookCopyId);
    }
}
