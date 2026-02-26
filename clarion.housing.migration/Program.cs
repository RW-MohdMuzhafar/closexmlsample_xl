using clarion.housing.console.migration.Services;

var coreData = ExcelReader.GetCoreData();

// PROPERTY COMPLIANCE



// CORE DATA
//var stream = ExcelReader.ExportFilteredCoreDataAsStream(coreData);

//using var fileStream = new FileStream(@"C:\Temp\CoreData.xlsx", FileMode.Create, FileAccess.Write);
//await stream.CopyToAsync(fileStream);
//await fileStream.FlushAsync();


// CASES
//var allCustomerReferences = coreData.Tenants.Select(t => t.TenancyReference);

//foreach (var tenant in coreData.Tenants)
//{
//    var customerRef = tenant.TenancyReference;
//    var uprn = tenant.UnitId; // (Unit Id)

//    // PARK - DONE FOR NOW TO DO PULL BACK ON USER CODE.
//    ExcelReader.ExportFilteredCaseData(
//        @"C:\Temp\FilteredCases.xlsx",
//        proceeding => proceeding.CustomerReference == customerRef,  // CustomerReference
//        abandonment => abandonment.CustomerReference == customerRef, // 
//        advice => advice.CustomerRef == customerRef,
//        breach => breach.Breach1 != null, // Customer ref required/missing.
//        welcome => welcome.Uprn == uprn // map uprn to property/customer ref. 
//    );

//    // To do - upload to correct area in CRM.

//}

Console.WriteLine("Hello, World!");
