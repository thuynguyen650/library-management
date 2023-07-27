using AutoMapper;
using LibraryManagement.Application.Queries.BookCopies;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Application.QueryHandlers.BookCopies;

public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookDetails>>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllBooksQueryHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<BookDetails>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
    {
        var books = await _context.Set<Book>()
                .Include(x => x.Authors)
                .Include(x => x.BookCopies)
                    .ThenInclude(x => x.Publisher)
                .Include(x => x.BookCategory)
            .ToListAsync(cancellationToken);

        var bookDetailsList = _mapper.Map<List<BookDetails>>(books);

        return bookDetailsList;
    }
}
