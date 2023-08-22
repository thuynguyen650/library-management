using AutoMapper;
using LibraryManagement.Application.Features.Books.Commands.CreateBook;
using LibraryManagement.Application.Features.Books.Queries.GetAllBooks;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.MappingProfiles;

public class BookProfile : Profile
{
    public BookProfile()
    {
        CreateMap<CreateBookCommand, Book>();
        CreateMap<Book, BookDto>();
    }
}
