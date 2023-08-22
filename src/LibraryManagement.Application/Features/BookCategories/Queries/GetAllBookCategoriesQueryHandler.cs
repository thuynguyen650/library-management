using AutoMapper;
using LibraryManagement.Application.Contracts.Persistence;
using MediatR;

namespace LibraryManagement.Application.Features.BookCategories.Queries;

public class GetAllBookCategoriesQueryHandler : IRequestHandler<GetAllBookCategoriesQuery, List<BookCategoryDto>>
{
    private readonly IMapper _mapper;
    private readonly IBookCategoryRepository _repository;

    public GetAllBookCategoriesQueryHandler(IMapper mapper, IBookCategoryRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<List<BookCategoryDto>> Handle(GetAllBookCategoriesQuery request, CancellationToken cancellationToken)
    {
        var bookCategories = await _repository.GetAllAsync();

        var result = _mapper.Map<List<BookCategoryDto>>(bookCategories);

        return result;
    }
}
