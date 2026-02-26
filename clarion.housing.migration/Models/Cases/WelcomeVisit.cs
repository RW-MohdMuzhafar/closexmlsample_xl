namespace clarion.housing.console.migration.Models.Cases
{
    public class WelcomeVisit
    {
        [ExcelHeader("Prop Reference (\"UPRN\")")] public string? Uprn { get; set; }
        [ExcelHeader("Block/Estate Code / Scheme Reference")] public string? SchemeReference { get; set; }
        [ExcelHeader("General needs, Shared Ownership, Supported,  Sheltered, Commercial, Leasehold")] public string? PropertyCategory { get; set; }
        [ExcelHeader("Address 1")] public string? Address1 { get; set; }
        [ExcelHeader("Address 2")] public string? Address2 { get; set; }
        [ExcelHeader("Town")] public string? Town { get; set; }
        [ExcelHeader("Postcode")] public string? Postcode { get; set; }
        [ExcelHeader("Local Authority")] public string? LocalAuthority { get; set; }
        [ExcelHeader("Property Type (House, Bungalow, Flat, Mais, Bedsit, Rooms)")] public string? PropertyType { get; set; }
        [ExcelHeader("Active Process")] public string? ActiveProcess { get; set; }
    }
}
