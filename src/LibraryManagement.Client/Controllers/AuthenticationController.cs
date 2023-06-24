using LibraryManagement.Application.Commands.Authentication;
using LibraryManagement.Domain.Entities.Authentication;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Client.Controllers;

public class AuthenticationController : ApiControllerBase
{
    private readonly ISender _mediator;

    public AuthenticationController(
        ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route("register")]
    public async Task<IActionResult> Register([FromBody] CreateUserCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}
