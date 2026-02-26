using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clarion.housing.console.migration.Models.Core
{
    public class Tenancy
    {
        [ExcelHeader("Unit ID")] public string? UnitId { get; set; }
        [ExcelHeader("Tenancy Reference")] public string? TenancyRef { get; set; }
        [ExcelHeader("Tenancy Start Date")] public DateTime? StartDate { get; set; }
        [ExcelHeader("Tenancy End Date")] public DateTime? EndDate { get; set; }
        [ExcelHeader("Payment Method")] public string? PaymentMethod { get; set; }
        [ExcelHeader("End Reason")] public string? EndReason { get; set; }
        [ExcelHeader("Use Correspondence Address")] public string? UseCorrespondenceAddress { get; set; }
        [ExcelHeader("Correspondence Name 1")] public string? CorrespondenceName1 { get; set; }
        [ExcelHeader("Correspondence Address Line 1")] public string? CorrespondenceAddress1 { get; set; }
        [ExcelHeader("Correspondence Address Line 2")] public string? CorrespondenceAddress2 { get; set; }
        [ExcelHeader("Correspondence Address Line 3")] public string? CorrespondenceAddress3 { get; set; }
        [ExcelHeader("Correspondence Address Line 4")] public string? CorrespondenceAddress4 { get; set; }
        [ExcelHeader("Correspondence Postcode")] public string? CorrespondencePostcode { get; set; }
        [ExcelHeader("Shared Ownership Indicator")] public string? SharedOwnershipIndicator { get; set; }
        [ExcelHeader("Property Owner Equity Value")] public decimal? PropertyOwnerEquityValue { get; set; }
        [ExcelHeader("TenancyBalArrears")] public decimal? TenancyBalArrears { get; set; }
        [ExcelHeader("Address Line 1")] public string? AddressLine1 { get; set; }
        [ExcelHeader("Address Line 2")] public string? AddressLine2 { get; set; }
        [ExcelHeader("Address Line 3")] public string? AddressLine3 { get; set; }
        [ExcelHeader("Postcode")] public string? Postcode { get; set; }
        [ExcelHeader("Charge Period")] public string? ChargePeriod { get; set; }
        [ExcelHeader("Charge Frequency")] public string? ChargeFrequency { get; set; }
        [ExcelHeader("Rent Amount")] public decimal? RentAmount { get; set; }
        [ExcelHeader("Service Charge Amount")] public decimal? ServiceChargeAmount { get; set; }
        [ExcelHeader("TenancyBalCredit")] public decimal? TenancyBalCredit { get; set; }
        [ExcelHeader("TenancyOtherArrears")] public decimal? TenancyOtherArrears { get; set; }
        [ExcelHeader("TenancyOtherCredit")] public decimal? TenancyOtherCredit { get; set; }
        [ExcelHeader("Agreement Type")] public string? AgreementType { get; set; }
        [ExcelHeader("FormerUnitBal")] public decimal? FormerUnitBal { get; set; }
        [ExcelHeader("Tenancy Status Active/Former")] public string? TenancyStatus { get; set; }
        [ExcelHeader("AccountNumber")] public string? AccountNumber { get; set; }
        [ExcelHeader("Tenancy Product Type")] public string? TenancyProductType { get; set; }
        [ExcelHeader("Rent Type")] public string? RentType { get; set; }
        [ExcelHeader("Tenure Type")] public string? TenureType { get; set; }
        [ExcelHeader("Fixed Service Charge")] public string? FixedServiceCharge { get; set; }
        [ExcelHeader("Rent Review Date")] public DateTime? RentReviewDate { get; set; }
        [ExcelHeader("Agreement Review Date")] public DateTime? AgreementReviewDate { get; set; }
        [ExcelHeader("Sinking Fund")] public string? SinkingFund { get; set; }
        [ExcelHeader("Transfer Name")] public string? TransferName { get; set; }
    }
}
