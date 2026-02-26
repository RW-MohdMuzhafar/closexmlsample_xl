using clarion.housing.console.migration.Models.Cases;
using FluentValidation;

namespace clarion.housing.console.migration.Validation.Validators
{
    public class AbandonmentValidator : AbstractValidator<Abandonment>
    {
        public AbandonmentValidator()
        {
            //RuleFor(x => x.AbandonmentId).NotEmpty().WithMessage("Abandonment ID is required.");
            RuleFor(x => x.Reference).NotEmpty().WithMessage("Case Reference is required.");
            RuleFor(x => x.TenancyReference).NotEmpty().WithMessage("Tenancy Reference link is required.");
        }
    }
}
