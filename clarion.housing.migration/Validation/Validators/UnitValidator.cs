using clarion.housing.console.migration.Models.Core;
using FluentValidation;

namespace clarion.housing.console.migration.Validation.Validators;

public class UnitValidator : AbstractValidator<Unit>
{
    public UnitValidator()
    {
        RuleFor(x => x.UnitId).NotEmpty();
        RuleFor(x => x.PropertyId).NotEmpty();
    }
}
