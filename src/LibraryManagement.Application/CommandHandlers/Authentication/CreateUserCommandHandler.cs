using LibraryManagement.Application.Commands.Authentication;
using LibraryManagement.Domain.Entities.Authentication;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Application.CommandHandlers.Authentication;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly UserManager<User> _userManager;
    private readonly RoleManager<Role> _roleManager;
    private readonly IConfiguration _configuration;

    public CreateUserCommandHandler(
        UserManager<User> userManager,
        RoleManager<Role> roleManager,
        IConfiguration configuration)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _configuration = configuration;
    }

    public async Task<Guid> Handle(CreateUserCommand command, CancellationToken cancellationToken)
    {
        var userExists = await _userManager.FindByEmailAsync(command.Email);

        if (userExists != null)
        {
            throw new InvalidOperationException("This email address is already taken.");
        }

        User user = new User()
        {
            Email = command.Email,
            SecurityStamp = Guid.NewGuid().ToString(),
            UserName = command.Email
        };

        var result = await _userManager.CreateAsync(user, command.Password);

        if (!result.Succeeded)
            throw new ValidationException("Invalid information");

        return user.Id;
    }
}
