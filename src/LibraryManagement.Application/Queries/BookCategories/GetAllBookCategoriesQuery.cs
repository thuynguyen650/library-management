using MediatR;

namespace LibraryManagement.Application.Queries.BookCategories;

public record GetAllBookCategoriesQuery : IRequest<List<BookCategoryDetails>>
{
}
