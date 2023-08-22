using AutoMapper;
using LibraryManagement.Application.Contracts.Persistence;
using MediatR;

namespace LibraryManagement.Application.Features.Books.Queries.GetAllBooks;

public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookDto>>
{
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;

    public GetAllBooksQueryHandler(IBookRepository bookRepository, IMapper mapper)
    {
        _bookRepository = bookRepository;
        _mapper = mapper;
    }

    public async Task<List<BookDto>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
    {
        var books = await _bookRepository.GetAllBooksAsync();

        var result = _mapper.Map<List<BookDto>>(books);

        return result;
    }
}
