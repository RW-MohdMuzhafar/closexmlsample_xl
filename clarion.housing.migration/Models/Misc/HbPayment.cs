using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clarion.housing.console.migration.Models.Misc
{
    public class HbPayment
    {
        [ExcelHeader("Claim Ref")] public string? ClaimRef { get; set; }
        [ExcelHeader("Amount")] public decimal? Amount { get; set; }
        [ExcelHeader("Adjustment")] public decimal? Adjustment { get; set; }
        [ExcelHeader("Net Amount")] public decimal? NetAmount { get; set; }
        [ExcelHeader("Name")] public string? Name { get; set; }
        [ExcelHeader("Address")] public string? Address { get; set; }
        [ExcelHeader("Period From")] public DateTime? PeriodFrom { get; set; }
        [ExcelHeader("Period To")] public DateTime? PeriodTo { get; set; }
    }
}
