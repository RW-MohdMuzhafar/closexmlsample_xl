using clarion.housing.console.migration.Models.Cases;
using FluentValidation;

namespace clarion.housing.console.migration.Validation.Validators
{
    public class AdviceSupportValidator : AbstractValidator<AdviceSupport>
    {
        public AdviceSupportValidator()
        {
            RuleFor(x => x.Uprn).NotEmpty().WithMessage("Property Reference (UPRN) is required.");
            RuleFor(x => x.CustomerRef).NotEmpty().WithMessage("Customer Reference is required.");
            RuleFor(x => x.AdviceAndSupportWBA).NotEmpty().WithMessage("Advice and Support Reference (AS_WBA) is required.");
        }
    }
}
