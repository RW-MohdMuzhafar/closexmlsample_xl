namespace clarion.housing.console.migration.Models.Misc
{
    // Table: Completed Adaptations
    public class CompletedAdaptation
    {
        [ExcelHeader("AdaptUprn")] public string? Uprn { get; set; }
        [ExcelHeader("UnitID")] public string? UnitId { get; set; }
        [ExcelHeader("AdaptGroup")] public string? AdaptationGroup { get; set; }
        [ExcelHeader("Add")] public string? Address { get; set; }
        [ExcelHeader("LA")] public string? LocalAuthority { get; set; }
        [ExcelHeader("Funding")] public string? FundingSource { get; set; }
        [ExcelHeader("DateWorkComp")] public DateTime? CompletionDate { get; set; }
    }
}
