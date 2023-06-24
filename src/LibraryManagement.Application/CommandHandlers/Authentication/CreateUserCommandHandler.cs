using LibraryManagement.Application.Commands.Authentication;
using LibraryManagement.Domain.Entities.Authentication;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Application.CommandHandlers.Authentication;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly UserManager<User> userManager;
    private readonly RoleManager<Role> roleManager;
    private readonly IConfiguration _configuration;

    public CreateUserCommandHandler(
        UserManager<User> userManager,
        RoleManager<Role> roleManager,
        IConfiguration configuration)
    {
        this.userManager = userManager;
        this.roleManager = roleManager;
        _configuration = configuration;
    }

    public async Task<Guid> Handle(CreateUserCommand command, CancellationToken cancellationToken)
    {
        var userExists = await userManager.FindByEmailAsync(command.Email);

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

        var result = await userManager.CreateAsync(user, command.Password);

        if (!result.Succeeded)
            throw new ValidationException("Invalid information");

        return user.Id;
    }
}
