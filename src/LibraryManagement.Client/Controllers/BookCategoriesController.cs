using LibraryManagement.Application.Features.BookCategories.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Client.Controllers;

public class BookCategoriesController : ApiControllerBase
{
    public BookCategoriesController(ISender mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<List<BookCategoryDto>> GetAllBookCategories()
    {
        return await _mediator.Send(new GetAllBookCategoriesQuery());
    }
}
