using MediatR;

namespace LibraryManagement.Application.Features.BookCategories.Queries;

public class GetAllBookCategoriesQuery : IRequest<List<BookCategoryDto>>
{
}
