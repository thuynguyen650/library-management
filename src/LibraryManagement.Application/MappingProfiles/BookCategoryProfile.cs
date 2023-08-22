using AutoMapper;
using LibraryManagement.Application.Features.BookCategories.Queries;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.MappingProfiles;

public class BookCategoryProfile : Profile
{
    public BookCategoryProfile()
    {
        CreateMap<BookCategoryDto, BookCategory>().ReverseMap();
    }
}
