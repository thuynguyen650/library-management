using MediatR;

namespace LibraryManagement.Application.Commands.Authentication;

public record CreateUserCommand : IRequest<Guid>
{
    public required string Email { get; set; }

    public required string Password { get; set; }
}
