using AutoMapper;
using LibraryManagement.Application.Contracts.Persistence;
using MediatR;

namespace LibraryManagement.Application.Features.Authors.Queries.GetAllAuthors;

public class GetAllAuthorsQueryHandler : IRequestHandler<GetAllAuthorsQuery, List<AuthorDto>>
{
    private readonly IAuthorRepository _authorRepository;
    private readonly IMapper _mapper;

    public GetAllAuthorsQueryHandler(IAuthorRepository authorRepository, IMapper mapper)
    {
        _authorRepository = authorRepository;
        _mapper = mapper;
    }

    public async Task<List<AuthorDto>> Handle(GetAllAuthorsQuery request, CancellationToken cancellationToken)
    {
        var authors = await _authorRepository.GetAllAsync();

        var result = _mapper.Map<List<AuthorDto>>(authors);

        return result;
    }
}
