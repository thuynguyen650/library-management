using LibraryManagement.Application.Queries.BookCopies;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Client.Controllers;

public class BooksController : ApiControllerBase
{
    private readonly ISender _mediator;

    public BooksController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<BookCopyDetails>>> GetAllBookCopies()
    {
        return await _mediator.Send(new GetAllBookCopiesQuery());
    }
}
