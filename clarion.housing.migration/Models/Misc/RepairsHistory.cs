using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clarion.housing.console.migration.Models.Misc
{
    public class RepairHistoryCase
    {
        [ExcelHeader("Source")] public string? Source { get; set; }
        [ExcelHeader("JobNumber")] public string? JobNumber { get; set; }
        [ExcelHeader("ContractDescription")] public string? ContractDescription { get; set; }
        [ExcelHeader("PriorityDescription")] public string? PriorityDescription { get; set; }
        [ExcelHeader("LocationCode")] public string? LocationCode { get; set; }
        [ExcelHeader("UPRN")] public string? Uprn { get; set; }
        [ExcelHeader("JobAddrLine1")] public string? AddressLine1 { get; set; }
        [ExcelHeader("Postcode")] public string? Postcode { get; set; }
        [ExcelHeader("ShortJobDescription")] public string? ShortJobDescription { get; set; }
        [ExcelHeader("DateAndTimeJobRaised")] public DateTime? DateRaised { get; set; }
        [ExcelHeader("Financial Year")] public string? FinancialYear { get; set; }
        [ExcelHeader("JobStatusDescription")] public string? JobStatus { get; set; }
        [ExcelHeader("DateJobCompletedStatus3")] public DateTime? DateCompleted { get; set; }
        [ExcelHeader("JobOriginatorsRef")] public string? OriginatorRef { get; set; }
    }
}
