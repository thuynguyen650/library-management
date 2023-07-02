using AutoMapper;
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
    private readonly IMapper _mapper;

    public CreateUserCommandHandler(
        UserManager<User> userManager,
        IMapper mapper)
    {
        _userManager = userManager;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateUserCommand command, CancellationToken cancellationToken)
    {
        if (command.Password != command.PasswordConfirm)
        {
            throw new ValidationException("Password is mismatch");
        }
        var userExists = await _userManager.FindByEmailAsync(command.Email);

        if (userExists != null)
        {
            throw new InvalidOperationException("This email address is already taken.");
        }

        User user = _mapper.Map<User>(command);

        var result = await _userManager.CreateAsync(user, command.Password);

        if (!result.Succeeded)
            throw new ValidationException(result.Errors.FirstOrDefault()?.Description);

        return user.Id;
    }
}
