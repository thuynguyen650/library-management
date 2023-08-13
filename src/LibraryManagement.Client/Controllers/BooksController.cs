using LibraryManagement.Application.Features.BookCopies.Queries.BookCopies;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Client.Controllers;

public class BooksController : ApiControllerBase
{
    public BooksController(ISender mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<ActionResult<List<BookCopyDetails>>> GetAllBookCopies()
    {
        return await _mediator.Send(new GetAllBookCopiesQuery());
    }
}
