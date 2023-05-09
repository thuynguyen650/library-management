using LibraryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.Infrastructure.Persistence.EntitiesConfiguration;

public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
{
    public void Configure(EntityTypeBuilder<BookCategory> builder)
    {
        builder.HasKey(bookCategory => bookCategory.Id);

        builder.HasMany(bookCategory => bookCategory.Books)
            .WithOne(book => book.BookCategory)
            .HasForeignKey(book => book.BookCategoryId);

    }
}
