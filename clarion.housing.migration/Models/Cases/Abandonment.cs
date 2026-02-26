using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clarion.housing.console.migration.Models.Cases
{
    public class Abandonment
    {
        // Hidden
        //[ExcelHeader("(Do Not Modify) Abandonment")] public string? AbandonmentId { get; set; }
        //[ExcelHeader("(Do Not Modify) Row Checksum")] public string? RowChecksum { get; set; }
        //[ExcelHeader("(Do Not Modify) Modified On")] public DateTime? SystemModifiedOn { get; set; }
        [ExcelHeader("Name")] public string? Name { get; set; }
        [ExcelHeader("Reference")] public string? Reference { get; set; }
        [ExcelHeader("Customer")] public string? Customer { get; set; }
        [ExcelHeader("Reference (Customer) (Contact)")] public string? CustomerReference { get; set; }
        [ExcelHeader("Reference (Customer Contract) (Contract)")] public string? TenancyReference { get; set; }
        [ExcelHeader("Created On")] public DateTime? CreatedOn { get; set; }
        [ExcelHeader("Owner")] public string? Owner { get; set; }
        [ExcelHeader("Housing Management Region (Customer) (Contact)")] public string? Region { get; set; }
        [ExcelHeader("Abandonment Suspected?")] public string? AbandonmentSuspected { get; set; }
        [ExcelHeader("Modified On")] public DateTime? ModifiedOn { get; set; }
        [ExcelHeader("Control Status (Customer Contract) (Contract)")] public string? ControlStatus { get; set; }
        [ExcelHeader("Tenancy Type (Customer Contract) (Contract)")] public string? TenancyType { get; set; }
        [ExcelHeader("Send Communication")] public string? SendCommunication { get; set; }
        [ExcelHeader("Address 1 (Customer) (Contact)")] public string? CustomerAddress { get; set; }
    }
}
