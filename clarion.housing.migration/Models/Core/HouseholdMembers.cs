namespace clarion.housing.console.migration.Models.Core
{
    public class HouseholdMembers
    {
        [ExcelHeader("Unit ID")] public string? UnitId { get; set; }
        [ExcelHeader("Tenancy Reference")] public string? TenancyReference { get; set; }
        [ExcelHeader("Household Member Reference")] public string? HouseholdMemberReference { get; set; }
        [ExcelHeader("Tenancy Start Date")] public DateTime? TenancyStartDate { get; set; }
        [ExcelHeader("Primary Payment Method")] public string? PrimaryPaymentMethod { get; set; }
        [ExcelHeader("Secondary Payment Method")] public string? SecondaryPaymentMethod { get; set; }
        [ExcelHeader("Title")] public string? Title { get; set; }
        [ExcelHeader("Surname")] public string? Surname { get; set; }
        [ExcelHeader("Forename")] public string? Forename { get; set; }
        [ExcelHeader("Date of Birth")] public DateTime? DateOfBirth { get; set; }
        [ExcelHeader("Ethnic Origin")] public string? EthnicOrigin { get; set; }
        [ExcelHeader("NI Number")] public string? NiNumber { get; set; }
        [ExcelHeader("Gender")] public string? Gender { get; set; }
        [ExcelHeader("Main Spoken Language")] public string? MainSpokenLanguage { get; set; }
        [ExcelHeader("Disability")] public string? Disability { get; set; }
        [ExcelHeader("Adaptations/Reasonable Adjustments")] public string? Adaptations { get; set; }
        [ExcelHeader("Email")] public string? Email { get; set; }
        [ExcelHeader("Home Telephone Number")] public string? HomePhone { get; set; }
        [ExcelHeader("Mobile Telephone Number")] public string? MobilePhone { get; set; }
        [ExcelHeader("Relationship to Main Tenant")] public string? RelationshipToMainTenant { get; set; }
        [ExcelHeader("Main Contact")] public string? MainContact { get; set; }
        [ExcelHeader("Address Line 1")] public string? AddressLine1 { get; set; }
        [ExcelHeader("Address Line 2")] public string? AddressLine2 { get; set; }
        [ExcelHeader("Address Line 3")] public string? AddressLine3 { get; set; }
        [ExcelHeader("Postcode")] public string? Postcode { get; set; }
        [ExcelHeader("Preferred Contact Method")] public string? PreferredContactMethod { get; set; }
        [ExcelHeader("Transfer Name")] public string? TransferName { get; set; }

        [ExcelHeader("Home Telephone")]
        public string HomeTelephone { get; set; } = "";

        [ExcelHeader("Mobile Telephone")]
        public string MobileTelephone { get; set; } = "";
    }
}
