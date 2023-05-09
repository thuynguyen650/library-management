using LibraryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.Infrastructure.Persistence.EntitiesConfiguration;

public class PatronConfiguration : IEntityTypeConfiguration<Patron>
{
    public void Configure(EntityTypeBuilder<Patron> builder)
    {
        builder.HasKey(patron => patron.Id);

        builder.HasMany(patron => patron.WaitingLists)
            .WithOne(waitingList => waitingList.Patron)
            .HasForeignKey(waitingList => waitingList.PatronId);

        builder.HasMany(patron => patron.Holds)
        .WithOne(hold => hold.Patron)
        .HasForeignKey(hold => hold.PatronId);

        builder.HasMany(patron => patron.Checkouts)
            .WithOne(checkout => checkout.Patron)
            .HasForeignKey(checkout => checkout.PatronId);

        builder.HasMany(bookCopy => bookCopy.Notifications)
            .WithOne(notification => notification.Patron)
            .HasForeignKey(notification => notification.PatronId);
    }
}
