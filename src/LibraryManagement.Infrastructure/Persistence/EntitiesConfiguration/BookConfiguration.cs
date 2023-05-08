using LibraryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.Infrastructure.Persistence.EntitiesConfiguration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(book => book.Id);

        builder.HasMany(book => book.BookCopies)
            .WithOne(bookCopy => bookCopy.Book)
            .HasForeignKey(bookCopy => bookCopy.BookId);

        builder.HasMany(book => book.BookAuthorList)
            .WithOne(bookAuthorList => bookAuthorList.Book)
            .HasForeignKey(bookAuthorList => bookAuthorList.BookId);
    }
}
