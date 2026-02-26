namespace clarion.housing.console.migration.Models.Misc
{
    public class AssetComponent
    {
        [ExcelHeader("UnitID")] public string? UnitId { get; set; }
        [ExcelHeader("PropertyID")] public string? PropertyId { get; set; }
        [ExcelHeader("ElementGroupName")] public string? ElementGroup { get; set; }
        [ExcelHeader("ElementName")] public string? ElementName { get; set; }
        [ExcelHeader("ElementTypeName")] public string? ElementType { get; set; }
        [ExcelHeader("ComponentID")] public string? ComponentId { get; set; }
        [ExcelHeader("Quantity")] public double? Quantity { get; set; }
        [ExcelHeader("InstallDate")] public DateTime? InstallDate { get; set; }
        [ExcelHeader("PlannedReplacementDate")] public DateTime? PlannedReplacementDate { get; set; }
        [ExcelHeader("StandardCost")] public decimal? StandardCost { get; set; }
        [ExcelHeader("LocalAuthority")] public string? LocalAuthority { get; set; }
    }
}
