namespace clarion.housing.console.migration.Models.Misc
{
    public class InsuranceHistory
    {
        [ExcelHeader("Claim Ref")] public string? ClaimRef { get; set; }
        [ExcelHeader("Loss Date")] public DateTime? LossDate { get; set; }
        [ExcelHeader("Claim Address")] public string? ClaimAddress { get; set; }
        [ExcelHeader("Post Code")] public string? PostCode { get; set; }
        [ExcelHeader("Claim Cause")] public string? ClaimCause { get; set; }
        [ExcelHeader("Claim Sub-Cause")] public string? ClaimSubCause { get; set; }
        [ExcelHeader("Claim Description")] public string? ClaimDescription { get; set; }
        [ExcelHeader("Position")] public string? Position { get; set; }
        [ExcelHeader("Claim Status")] public string? ClaimStatus { get; set; }
        [ExcelHeader("Outstanding Reserve")] public decimal? OutstandingReserve { get; set; }
        [ExcelHeader("Paid Less Recoveries")] public decimal? PaidLessRecoveries { get; set; }
        [ExcelHeader("Total Less Recoveries")] public decimal? TotalLessRecoveries { get; set; }
        [ExcelHeader("Product Target")] public string? ProductTarget { get; set; }
        [ExcelHeader("Notification Date")] public DateTime? NotificationDate { get; set; }
        [ExcelHeader("Settled Date")] public DateTime? SettledDate { get; set; }
        [ExcelHeader("Within Excess")] public string? WithinExcess { get; set; }
    }
}
