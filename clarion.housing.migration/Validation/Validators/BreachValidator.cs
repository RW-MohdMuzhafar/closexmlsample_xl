using clarion.housing.console.migration.Models.Cases;
using FluentValidation;

namespace clarion.housing.console.migration.Validation.Validators
{
    public class BreachValidator : AbstractValidator<TenancyBreach>
    {
        public BreachValidator()
        {
            RuleFor(x => x.Reference).NotEmpty().WithMessage("Breach Reference is required.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Case Name is required.");
            RuleFor(x => x.PropertyUnit).NotEmpty().WithMessage("Property/Unit link is required.");
        }
    }
}
