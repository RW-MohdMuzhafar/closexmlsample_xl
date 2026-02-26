namespace clarion.housing.console.migration.Models
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ExcelHeaderAttribute : Attribute
    {
        public string HeaderName { get; }
        public ExcelHeaderAttribute(string headerName) => HeaderName = headerName;
    }
}
