using LibraryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.Infrastructure.Persistence.EntitiesConfiguration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.Id);

/*        builder.HasMany(user => user.WaitingLists)
            .WithOne(waitingList => waitingList.User)
            .HasForeignKey(waitingList => waitingList.UserId);*/

        builder.HasMany(user => user.Holds)
        .WithOne(hold => hold.User)
        .HasForeignKey(hold => hold.UserId);

        builder.HasMany(user => user.Checkouts)
            .WithOne(checkout => checkout.User)
            .HasForeignKey(checkout => checkout.UserId);

        builder.HasMany(user => user.Notifications)
            .WithOne(notification => notification.User)
            .HasForeignKey(notification => notification.UserId);
    }
}
