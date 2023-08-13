using LibraryManagement.Application.Features.Authors.Queries.GetAllAuthors;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Client.Controllers
{
    public class AuthorsController : ApiControllerBase
    {
        public AuthorsController(ISender mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<List<AuthorDto>> GetAllAuthors()
        {
            return await _mediator.Send(new GetAllAuthorsQuery());
        }
    }
}
