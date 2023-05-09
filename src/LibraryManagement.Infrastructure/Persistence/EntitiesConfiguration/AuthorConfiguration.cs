using LibraryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.Infrastructure.Persistence.EntitiesConfiguration;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(author => author.Id);

        builder.HasMany(author => author.BookAuthorList)
            .WithOne(bookAuthorList => bookAuthorList.Author)
            .HasForeignKey(bookAuthorList => bookAuthorList.AuthorId);
    }
}
