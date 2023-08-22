using LibraryManagement.Application.Features.BookCopies.Queries.BookCopies;
using LibraryManagement.Application.Features.Books.Commands.CreateBook;
using LibraryManagement.Application.Features.Books.Queries.GetAllBooks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Client.Controllers;

public class BooksController : ApiControllerBase
{
    public BooksController(ISender mediator) : base(mediator)
    {
    }

    [HttpGet]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult<List<BookDto>>> GetAllBooks()
    {
        return await _mediator.Send(new GetAllBooksQuery());
    }

    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    [ProducesDefaultResponseType]
    public async Task<Guid> CreateBook(CreateBookCommand command)
    {
        return await _mediator.Send(command);
    }
}
