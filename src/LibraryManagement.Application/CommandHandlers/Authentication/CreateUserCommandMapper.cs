using AutoMapper;
using LibraryManagement.Application.Commands.Authentication;
using LibraryManagement.Domain.Entities.Authentication;

namespace LibraryManagement.Application.CommandHandlers.Authentication;

public class CreateUserCommandMapper : Profile
{
    public CreateUserCommandMapper()
    {
        CreateMap<CreateUserCommand, User>()
            .ForMember(dest => dest.UserName, opts => opts.MapFrom(src => src.Email));
    }
}
