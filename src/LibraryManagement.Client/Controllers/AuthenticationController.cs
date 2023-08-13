using LibraryManagement.Application.Features.Authentication.Commands.Authentication;
using LibraryManagement.Domain.Entities.Authentication;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Client.Controllers;

public class AuthenticationController : ApiControllerBase
{
    public AuthenticationController(ISender mediator) : base(mediator)
    {
    }

    [HttpPost]
    [Route("register")]
    public async Task<IActionResult> Register(CreateUserCommand command)
    {
        try
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
        catch(ValidationException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Login(LoginCommand command)
    {
/*        try
        {*/
            var result = await _mediator.Send(command);
            return Ok(result);
/*        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (ValidationException ex)
        {
            return BadRequest(ex.Message);
        }*/
    }
}
