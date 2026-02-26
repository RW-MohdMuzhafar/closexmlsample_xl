using clarion.housing.console.migration.Models.Cases;
using FluentValidation;

namespace clarion.housing.console.migration.Validation.Validators
{
    public class WelcomeVisitValidator : AbstractValidator<WelcomeVisit>
    {
        public WelcomeVisitValidator()
        {
            RuleFor(x => x.Uprn).NotEmpty().WithMessage("Property Reference (UPRN) is required.");
            RuleFor(x => x.ActiveProcess).NotEmpty().WithMessage("The Active Process/Permission description cannot be empty.");
        }
    }
}
