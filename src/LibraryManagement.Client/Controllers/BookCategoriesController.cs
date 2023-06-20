using LibraryManagement.Application.Queries.BookCategories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Client.Controllers;

public class BookCategoriesController : ApiControllerBase
{
    private readonly ISender _mediator;

    public BookCategoriesController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBookCategories()
    {
        var categories = await _mediator.Send(new GetAllBookCategoriesQuery());
        return Ok(categories);
    }
}
