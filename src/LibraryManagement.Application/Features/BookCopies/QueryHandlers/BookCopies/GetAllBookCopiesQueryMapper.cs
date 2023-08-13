using AutoMapper;
using LibraryManagement.Application.Features.BookCopies.Queries.BookCopies;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Features.BookCopies.QueryHandlers.BookCopies;

public class GetAllBookCopiesQueryMapper : Profile
{
    public GetAllBookCopiesQueryMapper()
    {
        CreateMap<BookCopy, BookCopyDetails>()
            .ForMember(dest => dest.Publisher, opts => opts.MapFrom(src => src.Publisher.Name));

        CreateMap<Book, BookDetails>()
            .ForMember(dest => dest.BookCategory, opts =>
            opts.MapFrom(src => JoinCategories(src.BookCategories.Select(c => c.Name).ToList())));

        CreateMap<Author, AuthorDetails>();
    }

    private string JoinCategories(List<string> categories)
    {
        return string.Join(", ", categories);
    }
}