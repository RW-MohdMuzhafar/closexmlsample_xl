namespace clarion.housing.console.migration.Models.Misc
{
    public class CustomerBalance
    {
        [ExcelHeader("Prop Reference (\"UPRN\")")] public string? Uprn { get; set; }
        [ExcelHeader("Block/Estate Code / Scheme Reference")] public string? EstateCode { get; set; }
        [ExcelHeader("C Reference")] public string? CReference { get; set; }
        [ExcelHeader("General needs, Shared Ownership, Supported,  Sheltered, Commercial, Leasehold")] public string? ProductType { get; set; }
        [ExcelHeader("Tenants Name")] public string? TenantsName { get; set; }
        [ExcelHeader("Address 1")] public string? Address1 { get; set; }
        [ExcelHeader("NOSP Y/N")] public string? NospActive { get; set; }
        [ExcelHeader("Date of NOSP")] public DateTime? DateOfNosp { get; set; }
        [ExcelHeader("Court Orders (SPO/OPO/ADJ)")] public string? CourtOrderType { get; set; }
        [ExcelHeader("Date of Court order")] public DateTime? DateOfCourtOrder { get; set; }
        [ExcelHeader("Court Costs (N/£)")] public string? CourtCosts { get; set; }
        [ExcelHeader("HB Reference if Applicable")] public string? HbReference { get; set; }
        [ExcelHeader("Weekly HB Award")] public decimal? WeeklyHbAward { get; set; }
        [ExcelHeader("Payment Method (DD/swipe Card/Allpay/UC/HB/SO/Debit/credit Card")] public string? PaymentMethod { get; set; }
        [ExcelHeader("UC - Is APA in place? Y/N")] public string? IsApaInPlace { get; set; }
        [ExcelHeader("Breathing Space Y/N")] public string? InBreathingSpace { get; set; }
        [ExcelHeader("Breathing Space End date")] public DateTime? BreathingSpaceEndDate { get; set; }
        [ExcelHeader("Is there an agreement in place Y/N, Date of Agreement")] public string? AgreementDetails { get; set; }
        [ExcelHeader("Amount  of Agreement")] public string? AgreementAmount { get; set; }
        [ExcelHeader("Comments")] public string? Comments { get; set; }
    }
}
