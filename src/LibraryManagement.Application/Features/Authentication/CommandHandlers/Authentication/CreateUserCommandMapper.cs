using AutoMapper;
using LibraryManagement.Application.Features.Authentication.Commands.Authentication;
using LibraryManagement.Domain.Entities.Authentication;

namespace LibraryManagement.Application.Features.Authentication.CommandHandlers.Authentication;

public class CreateUserCommandMapper : Profile
{
    public CreateUserCommandMapper()
    {
        CreateMap<CreateUserCommand, User>()
            .ForMember(dest => dest.UserName, opts => opts.MapFrom(src => src.Email));
    }
}
