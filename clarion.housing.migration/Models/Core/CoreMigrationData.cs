using clarion.housing.console.migration.Models.Cases;

namespace clarion.housing.console.migration.Models.Core
{
    public class CoreMigrationData
    {
        // Clean data lists
        public List<Property> Properties => PropertyResults.Select(r => r.Record).ToList();
        public List<Unit> Units => UnitResults.Select(r => r.Record).ToList();
        public List<Tenancy> Tenancies => TenancyResults.Select(r => r.Record).ToList();
        public List<Tenant> Tenants => TenantResults.Select(r => r.Record).ToList();
        public List<HouseholdMembers> HouseholdMembers => HouseholdMemberResults.Select(r => r.Record).ToList();

        // Validation results
        public List<RowValidationResult<Property>>? PropertyResults { get; set; } = new();
        public List<RowValidationResult<Unit>>? UnitResults { get; set; } = new();
        public List<RowValidationResult<Tenancy>>? TenancyResults { get; set; } = new();
        public List<RowValidationResult<Tenant>>? TenantResults { get; set; } = new();
        public List<RowValidationResult<HouseholdMembers>>? HouseholdMemberResults { get; set; } = new();

        // HasErrors focused only on core entities
        public bool HasErrors =>
            PropertyResults.Any(r => r.Errors.Any()) ||
            UnitResults.Any(r => r.Errors.Any()) ||
            TenancyResults.Any(r => r.Errors.Any()) ||
            TenantResults.Any(r => r.Errors.Any()) ||
            HouseholdMemberResults.Any(r => r.Errors.Any());
    }
}
