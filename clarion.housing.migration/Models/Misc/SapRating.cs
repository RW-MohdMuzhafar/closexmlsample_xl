namespace clarion.housing.console.migration.Models.Misc
{
    public class SapRating
    {
        [ExcelHeader("OrganisationReference")] public string? OrgRef { get; set; }
        [ExcelHeader("Address")] public string? Address { get; set; }
        [ExcelHeader("PostCode")] public string? PostCode { get; set; }
        [ExcelHeader("Borough")] public string? Borough { get; set; }
        [ExcelHeader("SAP")] public double? SapScore { get; set; }
        [ExcelHeader("EI")] public double? EiScore { get; set; }
        [ExcelHeader("Fuel Bills (£/yr)")] public decimal? FuelBill { get; set; }
        [ExcelHeader("tCO2")] public double? TCo2 { get; set; }
        [ExcelHeader("Lodgement Date")] public DateTime? LodgementDate { get; set; }
        [ExcelHeader("SAP version")] public string? SapVersion { get; set; }
        [ExcelHeader("Property Type")] public string? PropertyType { get; set; }
        [ExcelHeader("Main Fuel")] public string? MainFuel { get; set; }
        [ExcelHeader("kWh/m2")] public double? KWhM2 { get; set; }
    }
}
