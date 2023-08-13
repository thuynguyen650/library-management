using AutoMapper;
using LibraryManagement.Application.Contracts.Persistence;
using LibraryManagement.Application.Features.BookCopies.Queries.BookCopies;
using MediatR;

namespace LibraryManagement.Application.Features.BookCopies.QueryHandlers.BookCopies;

public class GetAllBookCopiesQueryHandler : IRequestHandler<GetAllBookCopiesQuery, List<BookCopyDetails>>
{
    private readonly IBookCopyRepository _repository;
    private readonly IMapper _mapper;

    public GetAllBookCopiesQueryHandler(IBookCopyRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<BookCopyDetails>> Handle(GetAllBookCopiesQuery request, CancellationToken cancellationToken)
    {
        var bookCopies = await _repository.GetAllAsync();

        var result = _mapper.Map<List<BookCopyDetails>>(bookCopies);

        return result;
    }
}
