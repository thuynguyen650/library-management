using MediatR;

namespace LibraryManagement.Application.Features.Authentication.Commands.Authentication;

public record CreateUserCommand : IRequest<Guid>
{
    public required string Email { get; set; }

    public required string Password { get; set; }

    public required string PasswordConfirm { get; set; }
}
