using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clarion.housing.console.migration.Models.Core
{
    public class Unit
    {
        [ExcelHeader("Unit ID")] public string? UnitId { get; set; }
        [ExcelHeader("Address Line 1")] public string? AddressLine1 { get; set; }
        [ExcelHeader("Address Line 2")] public string? AddressLine2 { get; set; }
        [ExcelHeader("Address Line 3")] public string? AddressLine3 { get; set; }
        [ExcelHeader("Address Line 4")] public string? AddressLine4 { get; set; }
        [ExcelHeader("Postcode")] public string? Postcode { get; set; }
        [ExcelHeader("Unit Type")] public string? UnitType { get; set; }
        [ExcelHeader("Property ID")] public string? PropertyId { get; set; }
        [ExcelHeader("NROSH Type")] public string? NroshType { get; set; }
        [ExcelHeader("Unit Product Type")] public string? UnitProductType { get; set; }
        [ExcelHeader("Local Authority")] public string? LocalAuthority { get; set; }
        [ExcelHeader("Number of Bedrooms")] public int? NumberOfBedrooms { get; set; }
        [ExcelHeader("Property Built Date")] public DateTime? PropertyBuiltDate { get; set; }
        [ExcelHeader("Management Company")] public string? ManagementCompany { get; set; }
        [ExcelHeader("Owned by Clarion")] public string? OwnedByClarion { get; set; }
        [ExcelHeader("Freeholder")] public string? Freeholder { get; set; }
        [ExcelHeader("Number of Bedspaces")] public int? NumberOfBedspaces { get; set; }
        [ExcelHeader("Total Number of Floors")] public int? TotalFloors { get; set; }
        [ExcelHeader("Construction Type")] public string? ConstructionType { get; set; }
        [ExcelHeader("Derivation Code")] public string? DerivationCode { get; set; }
        [ExcelHeader("Void or Occupied")] public string? VoidOrOccupied { get; set; }
        [ExcelHeader("Void Start Date")] public DateTime? VoidStartDate { get; set; }
        [ExcelHeader("Target Rent")] public decimal? TargetRent { get; set; }
        [ExcelHeader("Heating Type")] public string? HeatingType { get; set; }
        [ExcelHeader("LGSR Most Recent Date")] public DateTime? LgsrMostRecentDate { get; set; }
        [ExcelHeader("LGSR Next Due Date")] public DateTime? LgsrNextDueDate { get; set; }
        [ExcelHeader("1999 Property Valuation")] public decimal? PropertyValuation1999 { get; set; }
        [ExcelHeader("Unit Entry Level")] public string? UnitEntryLevel { get; set; }
        [ExcelHeader("Current Tenancy Actual End Date")] public DateTime? TenancyEndDate { get; set; }
        [ExcelHeader("Target Rent Frequency")] public string? TargetRentFrequency { get; set; }
        [ExcelHeader("Number of Storeys")] public int? NumberOfStoreys { get; set; }
        [ExcelHeader("SubType")] public string? SubType { get; set; }
        [ExcelHeader("Equity Owned by Customer")] public decimal? EquityOwnedByCustomer { get; set; }
        [ExcelHeader("Equity Retained by Clarion")] public decimal? EquityRetainedByClarion { get; set; }
        [ExcelHeader("Ground Rent Amount")] public decimal? GroundRentAmount { get; set; }
        [ExcelHeader("Ground Rent Review")] public DateTime? GroundRentReview { get; set; }
        [ExcelHeader("Current Lease Start Date")] public DateTime? LeaseStartDate { get; set; }
        [ExcelHeader("Lease Term Date")] public DateTime? LeaseTermDate { get; set; }
        [ExcelHeader("Lease Title Ref")] public string? LeaseTitleRef { get; set; }
        [ExcelHeader("Index Type")] public string? IndexType { get; set; }
        [ExcelHeader("Adjustment")] public decimal? Adjustment { get; set; }
        [ExcelHeader("Rent Anniversary Date")] public DateTime? RentAnniversaryDate { get; set; }
    }
}
