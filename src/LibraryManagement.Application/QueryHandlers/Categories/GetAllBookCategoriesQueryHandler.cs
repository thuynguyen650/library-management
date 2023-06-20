using LibraryManagement.Application.Queries.BookCategories;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Application.QueryHandlers.Categories;

public class GetAllBookCategoriesQueryHandler : IRequestHandler<GetAllBookCategoriesQuery, List<BookCategoryDetails>>
{
    private readonly ApplicationDbContext _dbContext;

    public GetAllBookCategoriesQueryHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<BookCategoryDetails>> Handle(GetAllBookCategoriesQuery request, CancellationToken cancellationToken)
    {
        var result = new List<BookCategoryDetails>();
        var categories = await _dbContext.Set<BookCategory>().ToListAsync(cancellationToken);

        foreach (var category in categories)
        {
            result.Add(new BookCategoryDetails
            {
                Name = category.Name
            });
        }

        return result;
    }
}
