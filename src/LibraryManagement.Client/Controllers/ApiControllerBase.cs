using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Client.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApiControllerBase : ControllerBase
{
    protected readonly ISender _mediator;

    public ApiControllerBase(ISender mediator)
    {
        _mediator = mediator;
    }
}
