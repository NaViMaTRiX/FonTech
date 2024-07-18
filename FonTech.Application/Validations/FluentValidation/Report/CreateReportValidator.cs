namespace FonTech.Application.Validations.FluentValidation.Report;

using FonTech.Domain.Dto.Report;
using global::FluentValidation;

public class CreateReportValidator : AbstractValidator<CreateReportDto>
{
    public CreateReportValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Description).NotEmpty().MaximumLength(1000);
    }
}