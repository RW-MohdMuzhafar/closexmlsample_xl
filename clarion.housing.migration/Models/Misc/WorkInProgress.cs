namespace clarion.housing.console.migration.Models.Misc
{
    public class WorkInProgress
    {
        [ExcelHeader("JobNumber")] public string? JobNumber { get; set; }
        [ExcelHeader("ContractDescription")] public string? Contract { get; set; }
        [ExcelHeader("PriorityDescription")] public string? Priority { get; set; }
        [ExcelHeader("JobAddrLine1")] public string? Address { get; set; }
        [ExcelHeader("Postcode")] public string? Postcode { get; set; }
        [ExcelHeader("ShortJobDescription")] public string? Description { get; set; }
        [ExcelHeader("DateAndTimeJobRaised")] public DateTime? DateRaised { get; set; }
        [ExcelHeader("JobStatusDescription")] public string? Status { get; set; }
        [ExcelHeader("AppointDate")] public DateTime? AppointmentDate { get; set; }
        [ExcelHeader("Trade")] public string? Trade { get; set; }
    }
}
