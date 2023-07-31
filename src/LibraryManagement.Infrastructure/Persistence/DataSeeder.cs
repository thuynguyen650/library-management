using LibraryManagement.Domain.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;

namespace LibraryManagement.Infrastructure.Persistence
{
    public static class DataSeeder
    {
        // Seed data
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                var booksForSeed = new List<Book>
                {
                    new Book
                    {
                        Title = "To Kill a Mockingbird",
                        BookCategories = new List<BookCategory>
                        {
                            new BookCategory
                            {
                                Name = "Fiction"
                            },
                            new BookCategory
                            {
                                Name = "Classics"
                            }
                        },
                        Authors = new List<Author>
                        {
                            new Author
                            {
                                Name = "Harper Lee"
                            }
                        }
                    },
                    new Book
                    {
                        Title = "Harry Potter and the Sorcerer's Stone",
                        BookCategories = new List<BookCategory>
                        {
                            new BookCategory
                            {
                                Name = "Fantasy"
                            },
                            new BookCategory
                            {
                                Name = "Young Adult"
                            }
                        },
                        Authors = new List<Author>
                        {
                            new Author
                            {
                                Name = "J.K. Rowling"
                            }
                        }
                    },
                    new Book
                    {
                        Title = "The Alchemist",
                        BookCategories = new List<BookCategory>
                        {
                            new BookCategory
                            {
                                Name = "Inspirational"
                            },
                            new BookCategory
                            {
                                Name = "Spiritual"
                            }
                        },
                        Authors = new List<Author>
                        {
                            new Author
                            {
                                Name = "Paulo Coelho"
                            }
                        }
                    },
                    new Book
                    {
                        Title = "1984",
                        BookCategories = new List<BookCategory>
                        {
                            new BookCategory
                            {
                                Name = "Science Fiction"
                            }
                        },
                        Authors = new List<Author>
                        {
                            new Author
                            {
                                Name = "George Orwell"
                            }
                        }
                    },
                    new Book
                    {
                        Title = "Becoming",
                        BookCategories = new List<BookCategory>
                        {
                            new BookCategory
                            {
                                Name = "Biography/Autobiography"
                            },
                            new BookCategory
                            {
                                Name = "Politics/Government"
                            }
                        },
                        Authors = new List<Author>
                        {
                            new Author
                            {
                                Name = "Michelle Obama"
                            }
                        }
                    }
                };

                var bookCopiesForSeed = new List<BookCopy>
                {
                    new BookCopy
                    {
                        Book = booksForSeed[0],
                        Publisher = new Publisher
                        {
                            Name = "J. B. Lippincott & Co."
                        },
                        YearPublished = 2000,
                        ImageUrl = "images/product-1.jpg"
                    },
                    new BookCopy
                    {
                        Book = booksForSeed[1],
                        Publisher = new Publisher
                        {
                            Name = "Bloomsbury (UK) / Scholastic (US)"
                        },
                        YearPublished = 2001,
                        ImageUrl = "images/product-5.jpg"
                    },
                    new BookCopy
                    {
                        Book = booksForSeed[2],
                        Publisher = new Publisher
                        {
                            Name = "HarperOne"
                        },
                        YearPublished = 2010,
                        ImageUrl = "images/product-2.jpg"
                    },
                    new BookCopy
                    {
                        Book = booksForSeed[3],
                        Publisher = new Publisher
                        {
                            Name = "Secker & Warburg (UK)"
                        },
                        YearPublished = 2003,
                        ImageUrl = "images/product-3.jpg"
                    },
                    new BookCopy
                    {
                        Book = booksForSeed[4],
                        Publisher = new Publisher
                        {
                            Name = "Crown Publishing Group"
                        },
                        YearPublished = 2023,
                        ImageUrl = "images/product-4.jpg"
                    },
                    new BookCopy
                    {
                        Book = booksForSeed[4],
                        Publisher = new Publisher
                        {
                            Name = "Crown Publishing Group 2"
                        },
                        YearPublished = 2023,
                        ImageUrl = "images/product-9.jpg"
                    },
                    new BookCopy
                    {
                        Book = booksForSeed[3],
                        Publisher = new Publisher
                        {
                            Name = "Crown Publishing Group 3"
                        },
                        YearPublished = 2023,
                        ImageUrl = "images/product-7.jpg"
                    }
                };

                context.Database.EnsureCreated();

                // use EnsureCreated before check the Book Copies
                if (!context.BookCopies.Any())
                {
                    context.BookCopies.AddRange(bookCopiesForSeed);

                    context.SaveChanges();
                }
            }
        }
    }
}
