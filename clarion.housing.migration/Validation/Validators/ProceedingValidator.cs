using clarion.housing.console.migration.Models.Cases;
using FluentValidation;

namespace clarion.housing.console.migration.Validation.Validators
{
    public class ProceedingValidator : AbstractValidator<Proceeding>
    {
        public ProceedingValidator()
        {
            RuleFor(x => x.Reference).NotEmpty().WithMessage("Initiate Proceeding Reference is required.");
            RuleFor(x => x.TenancyReference).NotEmpty().WithMessage("Tenancy Contract Reference is required.");
            RuleFor(x => x.CustomerReference).NotEmpty().WithMessage("Customer Reference is required.");
        }
    }
}
