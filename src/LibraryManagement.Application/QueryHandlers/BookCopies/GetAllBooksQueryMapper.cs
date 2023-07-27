using AutoMapper;
using LibraryManagement.Application.Queries.BookCopies;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.QueryHandlers.BookCopies;

public class GetAllBookCopiesQueryMapper : Profile
{
    public GetAllBookCopiesQueryMapper()
    {
        CreateMap<Book, BookDetails>()
            .ForMember(dest => dest.BookCategory, opts => opts.MapFrom(src => src.BookCategory.Name));
        CreateMap<Author, AuthorDetails>();
        CreateMap<BookCopy, BookCopyDetails>()
            .ForMember(dest => dest.Publisher, opts => opts.MapFrom(src => src.Publisher.Name));
    }
}