using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clarion.housing.console.migration.Models.Cases
{
    public class CaseMigrationData
    {
        // Clean data lists
        public List<Proceeding> ProceedingCases => ProceedingResults.Select(r => r.Record).ToList();
        public List<Abandonment> AbandonmentCases => AbandonmentResults.Select(r => r.Record).ToList();
        public List<AdviceSupport> AdviceSupportCases => AdviceSupportResults.Select(r => r.Record).ToList();
        public List<TenancyBreach> BreachCases => BreachResults.Select(r => r.Record).ToList();
        public List<WelcomeVisit> WelcomeVisits => WelcomeVisitResults.Select(r => r.Record).ToList();

        // Validation results
        public List<RowValidationResult<Proceeding>>? ProceedingResults { get; set; } = new();
        public List<RowValidationResult<Abandonment>>? AbandonmentResults { get; set; } = new();
        public List<RowValidationResult<AdviceSupport>>? AdviceSupportResults { get; set; } = new();
        public List<RowValidationResult<TenancyBreach>>? BreachResults { get; set; } = new();
        public List<RowValidationResult<WelcomeVisit>>? WelcomeVisitResults { get; set; } = new();

        // HasErrors focused only on case entities
        public bool HasErrors =>
            ProceedingResults.Any(r => r.Errors.Any()) ||
            AbandonmentResults.Any(r => r.Errors.Any()) ||
            AdviceSupportResults.Any(r => r.Errors.Any()) ||
            BreachResults.Any(r => r.Errors.Any()) ||
            WelcomeVisitResults.Any(r => r.Errors.Any());
    }
}
