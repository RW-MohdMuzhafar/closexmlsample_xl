using clarion.housing.console.migration.Models.Core;
using FluentValidation;

namespace clarion.housing.console.migration.Validation.Validators;

public class TenantValidator : AbstractValidator<Tenant>
{
    public TenantValidator()
    {
        RuleFor(x => x.TenantReference).NotEmpty();
        RuleFor(x => x.TenancyReference).NotEmpty();
    }
}
