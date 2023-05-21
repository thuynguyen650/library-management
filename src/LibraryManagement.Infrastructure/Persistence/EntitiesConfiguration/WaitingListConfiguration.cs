using LibraryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.Infrastructure.Persistence.EntitiesConfiguration;

public class WaitingListConfiguration : IEntityTypeConfiguration<WaitingList>
{
    public void Configure(EntityTypeBuilder<WaitingList> builder)
    {
        builder.HasKey(waitingList => new { waitingList.UserId, waitingList.BookId });
    }
}
