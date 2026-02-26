namespace clarion.housing.console.migration.Models.Misc
{
    // Table: Adaptations in progress
    public class InProgressAdaptation
    {
        [ExcelHeader("AdaptUprn")] public string? Uprn { get; set; }
        [ExcelHeader("UnitID")] public string? UnitId { get; set; }
        [ExcelHeader("AdaptGroup")] public string? AdaptationGroup { get; set; }
        [ExcelHeader("Add")] public string? Address { get; set; }
        [ExcelHeader("Funding")] public string? FundingSource { get; set; }
        [ExcelHeader("Comments")] public string? Comments { get; set; }
    }
}
