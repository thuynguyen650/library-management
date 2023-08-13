using AutoMapper;
using LibraryManagement.Application.Features.Authors.Queries.GetAllAuthors;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.MappingProfiles;

public class AuthorProfile : Profile
{
    public AuthorProfile()
    {
        CreateMap<AuthorDto, Author>().ReverseMap();
    }
}
