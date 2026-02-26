using clarion.housing.console.migration.Models.Core;
using FluentValidation;

namespace clarion.housing.console.migration.Validation.Validators;

public class PropertyValidator : AbstractValidator<Property>
{
    public PropertyValidator()
    {
        RuleFor(x => x.PropertyId).NotEmpty();
        RuleFor(x => x.Postcode).NotEmpty();
    }
}