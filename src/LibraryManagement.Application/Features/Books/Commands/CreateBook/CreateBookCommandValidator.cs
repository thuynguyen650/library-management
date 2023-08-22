using FluentValidation;

namespace LibraryManagement.Application.Features.Books.Commands.CreateBook;

public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    public CreateBookCommandValidator()
    {
        RuleFor(b => b.Title)
            .NotEmpty()
            .WithMessage("Book must have title.");

        RuleFor(b => b.ISBN)
            .NotEmpty()
            .WithMessage("Book must have ISBN")
            .Length(13)
            .WithMessage("ISBN must have exactly 13 characters.");

        RuleFor(b => b.Authors)
            .NotEmpty()
            .WithMessage("Book must have at least one author.");

        RuleFor(b => b.Categories)
            .NotEmpty()
            .WithMessage("Book must belong to at least one category.");

        RuleFor(b => b.PageNumber)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Page number is not valid.");
    }
}
