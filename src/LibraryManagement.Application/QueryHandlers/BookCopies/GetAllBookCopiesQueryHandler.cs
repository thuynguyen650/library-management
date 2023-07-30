using AutoMapper;
using LibraryManagement.Application.Queries.BookCopies;
using LibraryManagement.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Application.QueryHandlers.BookCopies;

public class GetAllBookCopiesQueryHandler : IRequestHandler<GetAllBookCopiesQuery, List<BookCopyDetails>>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllBookCopiesQueryHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<BookCopyDetails>> Handle(GetAllBookCopiesQuery request, CancellationToken cancellationToken)
    {
        var bookCopies = await _context.BookCopies
            .Include(c => c.Book)
                .ThenInclude(b => b.Authors)
            .Include(c => c.Book)
                .ThenInclude(b => b.BookCategories)
            .Include(c => c.Publisher)
            .ToListAsync(cancellationToken);

        var result = _mapper.Map<List<BookCopyDetails>>(bookCopies);

        return result;
    }
}
