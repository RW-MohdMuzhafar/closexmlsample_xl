namespace clarion.housing.console.migration.Models.Cases
{
    public class Proceeding
    {
        [ExcelHeader("Name")]
        public string? Name { get; set; }

        [ExcelHeader("Reference")]
        public string? Reference { get; set; }

        [ExcelHeader("Responsibility Name")]
        public string? ResponsibilityName { get; set; }

        [ExcelHeader("Customer")]
        public string? Customer { get; set; }

        [ExcelHeader("Address 1: Street 1 (Customer) (Contact)")]
        public string? StreetAddress { get; set; }

        [ExcelHeader("Address 1: ZIP/Postal Code (Customer) (Contact)")]
        public string? Postcode { get; set; }

        [ExcelHeader("Reference (Customer Contract) (Contract)")]
        public string? TenancyReference { get; set; }

        [ExcelHeader("Reference (Customer) (Contact)")]
        public string? CustomerReference { get; set; }

        [ExcelHeader("Start Date")]
        public DateTime? StartDate { get; set; }

        [ExcelHeader("Last Service Date")]
        public DateTime? LastServiceDate { get; set; }

        [ExcelHeader("Appointment Date")]
        public DateTime? AppointmentDate { get; set; }

        [ExcelHeader("Column1")]
        public string? Column1 { get; set; }
    }
}
