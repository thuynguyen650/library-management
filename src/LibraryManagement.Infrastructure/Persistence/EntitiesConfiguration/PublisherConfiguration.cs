using LibraryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.Infrastructure.Persistence.EntitiesConfiguration;

public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
{
    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
        builder.HasKey(publisher => publisher.Id);

        builder.HasMany(publisher => publisher.BookCopies)
            .WithOne(bookCopy => bookCopy.Publisher)
            .HasForeignKey(bookCopy => bookCopy.PublisherId);
    }
}
