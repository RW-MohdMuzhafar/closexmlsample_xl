using clarion.housing.console.migration.Models.Core;
using FluentValidation;

namespace clarion.housing.console.migration.Validation.Validators;

public class TenancyValidator : AbstractValidator<Tenancy>
{
    public TenancyValidator()
    {
        RuleFor(x => x.TenancyRef).NotEmpty();
        RuleFor(x => x.UnitId).NotEmpty();
    }
}
