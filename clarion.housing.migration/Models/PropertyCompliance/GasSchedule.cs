namespace clarion.housing.console.migration.Models.PropertyCompliance
{
    public class GasSchedule
    {
        [ExcelHeader("Prop Reference (\"UPRN\")")]
        public string? Uprn { get; set; }

        [ExcelHeader("Estate Code / Scheme Reference")]
        public string? EstateCode { get; set; }

        [ExcelHeader("Tenure Type")]
        public string? TenureType { get; set; }

        [ExcelHeader("Product Type")]
        public string? ProductType { get; set; }

        [ExcelHeader("Address 1")]
        public string? Address1 { get; set; }

        [ExcelHeader("Postcode")]
        public string? Postcode { get; set; }

        [ExcelHeader("Building Type")]
        public string? BuildingType { get; set; }

        [ExcelHeader("Local Authority")]
        public string? LocalAuthority { get; set; }

        [ExcelHeader("Domestic Gas Last Service Date")]
        public DateTime? DomesticGasLastServiceDate { get; set; }
    }
}
