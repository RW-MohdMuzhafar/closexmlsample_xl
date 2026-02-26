using clarion.housing.console.migration.Models.Cases;
using clarion.housing.console.migration.Models.Core;
using clarion.housing.console.migration.Validation.Validators;
using ClosedXML.Excel;
using FluentValidation;

namespace clarion.housing.console.migration.Services
{
    public static class SheetMapperInbound
    {
        public static List<RowValidationResult<T>>? GetCoreDataSet<T>()
        {
            List<RowValidationResult<T>>? resp = default;

            if (typeof(T) == typeof(Property))
                resp = ImportFromFiles(typeof(T).Name, "export", r => new Property
                {
                    PropertyId = r.GetString("Property ID"),
                    AddressLine1 = r.GetString("Address Line 1"),
                    AddressLine2 = r.GetString("Address Line 2"),
                    AddressLine3 = r.GetString("Address Line 3"),
                    AddressLine4 = r.GetString("Address Line 4"),
                    Postcode = r.GetString("Postcode"),
                    PropertyType = r.GetString("Property Type"),
                    LocalAuthority = r.GetString("Local Authority"),
                    PropertyBuiltDate = r.GetDate("Property Built Date"),
                    ManagementCompany = r.GetString("Management Company"),
                    OwnedByClarion = r.GetString("Owned by Clarion"),
                    Freeholder = r.GetString("Freeholder"),
                    TotalFloors = r.GetInt("Total Number of Floors"),
                    NumberOfUnits = r.GetInt("Number of Units"),
                    ConstructionType = r.GetString("Construction Type"),
                    HeatingType1 = r.GetString("Heating Type 1"),
                    HeatingType2 = r.GetString("Heating Type 2"),
                    HeatingType3 = r.GetString("Heating Type 3"),
                    ControlStatus = r.GetString("Control Status"),
                    ControlStatusEffectiveDate = r.GetDate("Control Status Effective Date"),
                    LgsrMostRecentDate = r.GetDate("LGSR Most Recent Date"),
                    LgsrNextDueDate = r.GetDate("LGSR Next Due Date"),
                    PropertyEntryLevel = r.GetInt("Property Entry Level"),
                    NumberOfStoreys = r.GetInt("Number of Storeys"),
                    SubType = r.GetString("SubType")
                }, new PropertyValidator()) as List<RowValidationResult<T>>;

            if (typeof(T) == typeof(Unit))
                resp = ImportFromFiles(typeof(T).Name, "export", r => new Unit
                {
                    UnitId = r.GetString("Unit ID"),
                    AddressLine1 = r.GetString("Address Line 1"),
                    AddressLine2 = r.GetString("Address Line 2"),
                    AddressLine3 = r.GetString("Address Line 3"),
                    AddressLine4 = r.GetString("Address Line 4"),
                    Postcode = r.GetString("Postcode"),
                    UnitType = r.GetString("Unit Type"),
                    PropertyId = r.GetString("Property ID"),
                    NroshType = r.GetString("NROSH Type"),
                    UnitProductType = r.GetString("Unit Product Type"),
                    LocalAuthority = r.GetString("Local Authority"),
                    NumberOfBedrooms = r.GetInt("Number of Bedrooms"),
                    PropertyBuiltDate = r.GetDate("Property Built Date"),
                    ManagementCompany = r.GetString("Management Company"),
                    OwnedByClarion = r.GetString("Owned by Clarion"),
                    Freeholder = r.GetString("Freeholder"),
                    NumberOfBedspaces = r.GetInt("Number of Bedspaces"),
                    TotalFloors = r.GetInt("Total Number of Floors"),
                    ConstructionType = r.GetString("Construction Type"),
                    DerivationCode = r.GetString("Derivation Code"),
                    VoidOrOccupied = r.GetString("Void or Occupied"),
                    VoidStartDate = r.GetDate("Void Start Date"),
                    TargetRent = r.GetDecimal("Target Rent"),
                    HeatingType = r.GetString("Heating Type"),
                    LgsrMostRecentDate = r.GetDate("LGSR Most Recent Date"),
                    LgsrNextDueDate = r.GetDate("LGSR Next Due Date"),
                    PropertyValuation1999 = r.GetDecimal("1999 Property Valuation"),
                    UnitEntryLevel = r.GetString("Unit Entry Level"),
                    TenancyEndDate = r.GetDate("Current Tenancy Actual End Date"),
                    TargetRentFrequency = r.GetString("Target Rent Frequency"),
                    NumberOfStoreys = r.GetInt("Number of Storeys"),
                    SubType = r.GetString("SubType"),
                    EquityOwnedByCustomer = r.GetDecimal("Equity Owned by Customer"),
                    EquityRetainedByClarion = r.GetDecimal("Equity Retained by Clarion"),
                    GroundRentAmount = r.GetDecimal("Ground Rent Amount"),
                    GroundRentReview = r.GetDate("Ground Rent Review"),
                    LeaseStartDate = r.GetDate("Current Lease Start Date"),
                    LeaseTermDate = r.GetDate("Lease Term Date"),
                    LeaseTitleRef = r.GetString("Lease Title Ref"),
                    IndexType = r.GetString("Index Type"),
                    Adjustment = r.GetDecimal("Adjustment"),
                    RentAnniversaryDate = r.GetDate("Rent Anniversary Date")
                }, new UnitValidator()) as List<RowValidationResult<T>>;

            if (typeof(T) == typeof(Tenancy))
                resp = ImportFromFiles(typeof(T).Name, "export", r => new Tenancy
                {
                    UnitId = r.GetString("Unit ID"),
                    TenancyRef = r.GetString("Tenancy Reference"),
                    StartDate = r.GetDate("Tenancy Start Date"),
                    EndDate = r.GetDate("Tenancy End Date"),
                    PaymentMethod = r.GetString("Payment Method"),
                    EndReason = r.GetString("End Reason"),
                    UseCorrespondenceAddress = r.GetString("Use Correspondence Address"),
                    CorrespondenceName1 = r.GetString("Correspondence Name 1"),
                    CorrespondenceAddress1 = r.GetString("Correspondence Address Line 1"),
                    CorrespondenceAddress2 = r.GetString("Correspondence Address Line 2"),
                    CorrespondenceAddress3 = r.GetString("Correspondence Address Line 3"),
                    CorrespondenceAddress4 = r.GetString("Correspondence Address Line 4"),
                    CorrespondencePostcode = r.GetString("Correspondence Postcode"),
                    SharedOwnershipIndicator = r.GetString("Shared Ownership Indicator"),
                    PropertyOwnerEquityValue = r.GetDecimal("Property Owner Equity Value"),
                    TenancyBalArrears = r.GetDecimal("TenancyBalArrears"),
                    AddressLine1 = r.GetString("Address Line 1"),
                    AddressLine2 = r.GetString("Address Line 2"),
                    AddressLine3 = r.GetString("Address Line 3"),
                    Postcode = r.GetString("Postcode"),
                    ChargePeriod = r.GetString("Charge Period"),
                    ChargeFrequency = r.GetString("Charge Frequency"),
                    RentAmount = r.GetDecimal("Rent Amount"),
                    ServiceChargeAmount = r.GetDecimal("Service Charge Amount"),
                    TenancyBalCredit = r.GetDecimal("TenancyBalCredit"),
                    TenancyOtherArrears = r.GetDecimal("TenancyOtherArrears"),
                    TenancyOtherCredit = r.GetDecimal("TenancyOtherCredit"),
                    AgreementType = r.GetString("Agreement Type"),
                    FormerUnitBal = r.GetDecimal("FormerUnitBal"),
                    TenancyStatus = r.GetString("Tenancy Status Active/Former"),
                    AccountNumber = r.GetString("AccountNumber"),
                    TenancyProductType = r.GetString("Tenancy Product Type"),
                    RentType = r.GetString("Rent Type"),
                    TenureType = r.GetString("Tenure Type"),
                    FixedServiceCharge = r.GetString("Fixed Service Charge"),
                    RentReviewDate = r.GetDate("Rent Review Date"),
                    AgreementReviewDate = r.GetDate("Agreement Review Date"),
                    SinkingFund = r.GetString("Sinking Fund"),
                    TransferName = r.GetString("Transfer Name")
                }, new TenancyValidator()) as List<RowValidationResult<T>>;

            if (typeof(T) == typeof(Tenant))
                resp = ImportFromFiles(typeof(T).Name, "export", r => new Tenant
                {
                    UnitId = r.GetString("Unit ID"),
                    TenancyReference = r.GetString("Tenancy Reference"),
                    TenantReference = r.GetString("Tenant Reference"),
                    TenancyStartDate = r.GetDate("Tenancy Start Date"),
                    PrimaryPaymentMethod = r.GetString("Primary Payment Method"),
                    SecondaryPaymentMethod = r.GetString("Secondary Payment Method"),
                    Title = r.GetString("Title"),
                    Surname = r.GetString("Surname"),
                    Forename = r.GetString("Forename"),
                    DateOfBirth = r.GetDate("Date of Birth"),
                    EthnicOrigin = r.GetString("Ethnic Origin"),
                    NiNumber = r.GetString("NI Number"),
                    Gender = r.GetString("Gender"),
                    MainSpokenLanguage = r.GetString("Main Spoken Language"),
                    MainWrittenLanguage = r.GetString("Main Written Language"),
                    Disability = r.GetString("Disability"),
                    Adaptations = r.GetString("Adaptations/Reasonable Adjustments"),
                    Email = r.GetString("Email"),
                    HomePhone = r.GetString("Home Telephone Number"),
                    MobilePhone = r.GetString("Mobile Telephone Number"),
                    DateCommenced = r.GetDate("Date Commenced"),
                    MainContact = r.GetString("Main Contact"),
                    AddressLine1 = r.GetString("Address Line 1"),
                    AddressLine2 = r.GetString("Address Line 2"),
                    AddressLine3 = r.GetString("Address Line 3"),
                    Postcode = r.GetString("Postcode"),
                    PrimaryTenant = r.GetString("Primary Tenant"),
                    SecondaryTenant = r.GetString("Secondary Tenant"),
                    PreferredContactMethod = r.GetString("Preferred Contact Method")
                    //Succession = r.GetString("Succession"),
                    //TransferName = r.GetString("Transfer Name"),
                    //Dpa = r.GetString("DPA"),
                    //Risk = r.GetString("Risk")
                }, new TenantValidator()) as List<RowValidationResult<T>>;

            if (typeof(T) == typeof(HouseholdMembers))
                resp = ImportFromFiles(typeof(T).Name, "export", r => new HouseholdMembers
                {
                    UnitId = r.GetString("Unit ID"),
                    TenancyReference = r.GetString("Tenancy Reference"),
                    HouseholdMemberReference = r.GetString("Household Member Reference"),
                    TenancyStartDate = r.GetDate("Tenancy Start Date"),
                    PrimaryPaymentMethod = r.GetString("Primary Payment Method"),
                    SecondaryPaymentMethod = r.GetString("Secondary Payment Method"),
                    Title = r.GetString("Title"),
                    Surname = r.GetString("Surname"),
                    Forename = r.GetString("Forename"),
                    DateOfBirth = r.GetDate("Date of Birth"),
                    EthnicOrigin = r.GetString("Ethnic Origin"),
                    NiNumber = r.GetString("NI Number"),
                    Gender = r.GetString("Gender"),
                    MainSpokenLanguage = r.GetString("Main Spoken Language"),
                    Disability = r.GetString("Disability"),
                    Adaptations = r.GetString("Adaptations/Reasonable Adjustments"),
                    Email = r.GetString("Email"),
                    HomeTelephone = r.GetString("Home Telephone Number"),
                    MobileTelephone = r.GetString("Mobile Telephone Number"),
                    RelationshipToMainTenant = r.GetString("Relationship to Main Tenant"),
                    MainContact = r.GetString("Main Contact"),
                    AddressLine1 = r.GetString("Address Line 1"),
                    AddressLine2 = r.GetString("Address Line 2"),
                    AddressLine3 = r.GetString("Address Line 3"),
                    Postcode = r.GetString("Postcode"),
                    PreferredContactMethod = r.GetString("Preferred Contact Method"),
                    TransferName = r.GetString("Transfer Name")
                }, new HouseholdMemberValidator()) as List<RowValidationResult<T>>;

            return resp;

            throw new NotSupportedException($"The type {typeof(T).Name} is not supported for sheet import.");
        }

        public static List<RowValidationResult<T>>? GetDataSet<T>(string excelWorkBookPath, string sheetName)
        {
            List<RowValidationResult<T>>? resp = default;

            using (var wb = new XLWorkbook(excelWorkBookPath))
            {
                #region Cases
                if (typeof(T) == typeof(Proceeding))
                    resp = ImportFromWorkbook(wb, sheetName, r => new Proceeding
                    {
                        Name = r.GetString("Name"),
                        Reference = r.GetString("Reference"),
                        ResponsibilityName = r.GetString("Responsibility Name"),
                        Customer = r.GetString("Customer"),
                        StreetAddress = r.GetString("Address 1: Street 1 (Customer) (Contact)"),
                        Postcode = r.GetString("Address 1: ZIP/Postal Code (Customer) (Contact)"),
                        TenancyReference = r.GetString("Reference (Customer Contract) (Contract)"),
                        CustomerReference = r.GetString("Reference (Customer) (Contact)"),
                        StartDate = r.GetDate("Start Date"),
                        LastServiceDate = r.GetDate("Last Service Date"),
                        AppointmentDate = r.GetDate("Appointment Date"),
                        Column1 = r.GetString("Column1")
                    }, new ProceedingValidator()) as List<RowValidationResult<T>>;

                if (typeof(T) == typeof(Abandonment))
                    resp = ImportFromWorkbook(wb, sheetName, r => new Abandonment
                    {
                        //AbandonmentId = r.GetString("(Do Not Modify) Abandonment"),
                        //RowChecksum = r.GetString("(Do Not Modify) Row Checksum"),
                        //ModifiedOn = r.GetDate("(Do Not Modify) Modified On"),
                        Name = r.GetString("Name"),
                        Reference = r.GetString("Reference"),
                        Customer = r.GetString("Customer"),
                        CustomerReference = r.GetString("Reference (Customer) (Contact)"),
                        TenancyReference = r.GetString("Reference (Customer Contract) (Contract)"),
                        CreatedOn = r.GetDate("Created On"),
                        ModifiedOn = r.GetDate("Modified On"),
                        Owner = r.GetString("Owner"),
                        Region = r.GetString("Housing Management Region (Customer) (Contact)"),
                        AbandonmentSuspected = r.GetString("Abandonment Suspected?"),
                        ControlStatus = r.GetString("Control Status (Customer Contract) (Contract)"),
                        TenancyType = r.GetString("Tenancy Type (Customer Contract) (Contract)"),
                        SendCommunication = r.GetString("Send Communication"),
                        CustomerAddress = r.GetString("Address 1 (Customer) (Contact)")
                    }, new AbandonmentValidator()) as List<RowValidationResult<T>>;

                if (typeof(T) == typeof(AdviceSupport))
                    resp = ImportFromWorkbook(wb, sheetName, r => new AdviceSupport
                    {
                        Uprn = r.GetString("Prop Reference (\"UPRN\")"),
                        SchemeReference = r.GetString("Block/Estate Code / Scheme Reference"),
                        PropertyCategory = r.GetString("General needs, Shared Ownership, Supported, Sheltered, Commercial, Leasehold"),
                        Address1 = r.GetString("Address 1"),
                        Address2 = r.GetString("Address 2"),
                        Town = r.GetString("Town"),
                        Postcode = r.GetString("Postcode"),
                        LocalAuthority = r.GetString("Local Authority"),
                        PropertyType = r.GetString("Property Type (House, Bungalow, Flat, Mais, Bedsit, Rooms)"),
                        CustomerRef = r.GetString("Customer Ref"),
                        AdviceAndSupport = r.GetString("A&S"),
                        AdviceAndSupportSO = r.GetString("A&S - SO"),
                        AdviceAndSupportWBA = r.GetString("A&S - WBA"),
                        CurrentStatus = r.GetString("Current Status/ Recent support provided"),
                        SupportRequired = r.GetString("Ongoing support required?"),
                        NextSteps = r.GetString("next steps required")
                    }, new AdviceSupportValidator()) as List<RowValidationResult<T>>;

                if (typeof(T) == typeof(TenancyBreach))
                    resp = ImportFromWorkbook(wb, sheetName, r => new TenancyBreach
                    {
                        Name = r.GetString("Name"),
                        Reference = r.GetString("Reference"),
                        PropertyUnit = r.GetString("Property / Unit"),
                        Breach1 = r.GetString("Breach 1"),
                        Breach2 = r.GetString("Breach 2"),
                        Breach3 = r.GetString("Breach 3"),
                        LastAction = r.GetString("Last Action"),
                        StartDate = r.GetDate("Start Date"),
                        ModifiedOn = r.GetDate("Modified On"),
                        Update = r.GetString("Update")
                    }, new BreachValidator()) as List<RowValidationResult<T>>;

                if (typeof(T) == typeof(WelcomeVisit))
                    resp = ImportFromWorkbook(wb, sheetName, r => new WelcomeVisit
                    {
                        Uprn = r.GetString("Prop Reference (\"UPRN\")"),
                        SchemeReference = r.GetString("Block/Estate Code / Scheme Reference"),
                        PropertyCategory = r.GetString("General needs, Shared Ownership, Supported, Sheltered, Commercial, Leasehold"),
                        Address1 = r.GetString("Address 1"),
                        Address2 = r.GetString("Address 2"),
                        Town = r.GetString("Town"),
                        Postcode = r.GetString("Postcode"),
                        LocalAuthority = r.GetString("Local Authority"),
                        PropertyType = r.GetString("Property Type (House, Bungalow, Flat, Mais, Bedsit, Rooms)"),
                        ActiveProcess = r.GetString("Active Process")
                    }, new WelcomeVisitValidator()) as List<RowValidationResult<T>>;
                #endregion
            }

            return resp;

            throw new NotSupportedException($"The type {typeof(T).Name} is not supported for sheet import.");
        }

        private static List<RowValidationResult<T>> ImportFromWorkbook<T>(
            XLWorkbook wb,
            string sheetName,
            Func<ExcelRow, T> map,
            IValidator<T> validator)
        {
            var sheet = wb.Worksheet(sheetName);
            return Importers.Import(sheet, map, validator);
        }

        /// <summary>
        /// Finds all files containing the entityName, opens the 'export' tab, and aggregates results.
        /// </summary>
        private static List<RowValidationResult<T>> ImportFromFiles<T>(
            string entityName,
            string sheetName,
            Func<ExcelRow, T> mapper,
            IValidator<T> validator)
        {
            var allResults = new List<RowValidationResult<T>>();

            // Assuming FileService can give you the directory or a list of files
            var files = FileService.GetInboundCoreDataFiles()
                .Where(f => f.Name.Replace(" ","").Contains(entityName, StringComparison.OrdinalIgnoreCase));

            foreach (var file in files)
            {
                using var wb = new XLWorkbook(file.FullName);
                var sheet = wb.Worksheet("export"); // Every file now uses 'export'

                var batchResults = Importers.Import(sheet, mapper, validator);
                allResults.AddRange(batchResults);
            }

            return allResults;
        }
    }
}
