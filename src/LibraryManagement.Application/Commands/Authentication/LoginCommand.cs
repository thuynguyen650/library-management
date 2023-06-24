using MediatR;
using System.IdentityModel.Tokens.Jwt;

namespace LibraryManagement.Application.Commands.Authentication;

public record LoginCommand : IRequest<string>
{
    public required string Email { get; set; }

    public required string Password { get; set; }
}
