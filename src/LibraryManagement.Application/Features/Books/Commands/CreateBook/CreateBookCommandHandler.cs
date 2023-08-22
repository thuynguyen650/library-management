using AutoMapper;
using FluentValidation;
using LibraryManagement.Application.Contracts.Persistence;
using LibraryManagement.Domain.Entities;
using MediatR;

namespace LibraryManagement.Application.Features.Books.Commands.CreateBook;

public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, Guid>
{
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;

    public CreateBookCommandHandler(IBookRepository bookRepository, IMapper mapper)
    {
        _bookRepository = bookRepository;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        // validate
        var validator = new CreateBookCommandValidator();

        var validationResult = validator.Validate(request);

        if (validationResult.Errors.Any())
        {
            throw new ValidationException("Book is not valid.");
        }

        var bookToCreate = _mapper.Map<Book>(request);

        await _bookRepository.CreateAsync(bookToCreate);

        return bookToCreate.Id;
    }
}
