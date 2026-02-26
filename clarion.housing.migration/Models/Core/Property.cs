using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clarion.housing.console.migration.Models.Core
{
    public class Property
    {
        [ExcelHeader("Property ID")] public string? PropertyId { get; set; }
        [ExcelHeader("Address Line 1")] public string? AddressLine1 { get; set; }
        [ExcelHeader("Address Line 2")] public string? AddressLine2 { get; set; }
        [ExcelHeader("Address Line 3")] public string? AddressLine3 { get; set; }
        [ExcelHeader("Address Line 4")] public string? AddressLine4 { get; set; }
        [ExcelHeader("Postcode")] public string? Postcode { get; set; }
        [ExcelHeader("Property Type")] public string? PropertyType { get; set; }
        [ExcelHeader("Local Authority")] public string? LocalAuthority { get; set; }
        [ExcelHeader("Property Built Date")] public DateTime? PropertyBuiltDate { get; set; }
        [ExcelHeader("Management Company")] public string? ManagementCompany { get; set; }
        [ExcelHeader("Owned by Clarion")] public string? OwnedByClarion { get; set; }
        [ExcelHeader("Freeholder")] public string? Freeholder { get; set; }
        [ExcelHeader("Total Number of Floors")] public int? TotalFloors { get; set; }
        [ExcelHeader("Number of Units")] public int? NumberOfUnits { get; set; }
        [ExcelHeader("Construction Type")] public string? ConstructionType { get; set; }
        [ExcelHeader("Heating Type 1")] public string? HeatingType1 { get; set; }
        [ExcelHeader("Heating Type 2")] public string? HeatingType2 { get; set; }
        [ExcelHeader("Heating Type 3")] public string? HeatingType3 { get; set; }
        [ExcelHeader("Control Status")] public string? ControlStatus { get; set; }
        [ExcelHeader("Control Status Effective Date")] public DateTime? ControlStatusEffectiveDate { get; set; }
        [ExcelHeader("LGSR Most Recent Date")] public DateTime? LgsrMostRecentDate { get; set; }
        [ExcelHeader("LGSR Next Due Date")] public DateTime? LgsrNextDueDate { get; set; }
        [ExcelHeader("Property Entry Level")] public int? PropertyEntryLevel { get; set; }
        [ExcelHeader("Number of Storeys")] public int? NumberOfStoreys { get; set; }
        [ExcelHeader("SubType")] public string? SubType { get; set; }
    }

}
