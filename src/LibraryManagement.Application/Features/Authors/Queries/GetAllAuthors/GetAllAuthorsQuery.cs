using MediatR;

namespace LibraryManagement.Application.Features.Authors.Queries.GetAllAuthors;

public class GetAllAuthorsQuery : IRequest<List<AuthorDto>>
{
}
