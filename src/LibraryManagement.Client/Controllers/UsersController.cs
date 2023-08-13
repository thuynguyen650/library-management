using MediatR;

namespace LibraryManagement.Client.Controllers;

public class UsersController : ApiControllerBase
{
    public UsersController(ISender mediator) : base(mediator)
    {
    }
}
