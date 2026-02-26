namespace clarion.housing.console.migration.Models.Misc
{
    public class Complaint
    {
        [ExcelHeader("Entered Queue")] public DateTime? DateEntered { get; set; }
        [ExcelHeader("Worked By")] public string? Handler { get; set; }
        [ExcelHeader("Name of Customer")] public string? CustomerName { get; set; }
        [ExcelHeader("Workstream")] public string? Workstream { get; set; }
        [ExcelHeader("Business Area")] public string? BusinessArea { get; set; }
        [ExcelHeader("Type of Complaint")] public string? ComplaintType { get; set; }
        [ExcelHeader("Address")] public string? Address { get; set; }
        [ExcelHeader("Postcode")] public string? Postcode { get; set; }
        [ExcelHeader("Region")] public string? Region { get; set; }
        [ExcelHeader("Latest Notes")] public string? Notes { get; set; }
    }
}
