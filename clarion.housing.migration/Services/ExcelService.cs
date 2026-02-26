using clarion.housing.console.migration.Models;
using clarion.housing.console.migration.Models.Cases;
using clarion.housing.console.migration.Models.Core;
using clarion.housing.console.migration.Models.PropertyCompliance;
using ClosedXML.Excel;
using FluentValidation;
using System.Reflection;

namespace clarion.housing.console.migration.Services
{
    public static class ExcelReader
    {
        public static CoreMigrationData GetCoreData()
        {
            var data = new CoreMigrationData();
            data.PropertyResults = SheetMapperInbound.GetCoreDataSet<Property>();
            data.UnitResults = SheetMapperInbound.GetCoreDataSet<Unit>();
            data.TenancyResults = SheetMapperInbound.GetCoreDataSet<Tenancy>();
            data.TenantResults = SheetMapperInbound.GetCoreDataSet<Tenant>();
            data.HouseholdMemberResults = SheetMapperInbound.GetCoreDataSet<HouseholdMembers>();
            return data;
        }

        public static CaseMigrationData GetAllCaseData()
        {
            var data = new CaseMigrationData();

            // 1. Initiate Proceedings Template
            data.ProceedingResults =
                SheetMapperInbound.GetDataSet<Proceeding>(
                    FileService.GetInboundDataFilePath(ExcelFileType.InitiateProceedings_14),
                    "Sheet1");

            // 2. Abandonments Template
            data.AbandonmentResults = SheetMapperInbound.GetDataSet<Abandonment>(
                FileService.GetInboundDataFilePath(ExcelFileType.Abandonments_15),
                "Abandonments - All Active O...");

            // 3. Advice and Support Cases Template
            data.AdviceSupportResults = SheetMapperInbound.GetDataSet<AdviceSupport>(
                FileService.GetInboundDataFilePath(ExcelFileType.AdviceAndSupportCases_16)
                , "Sheet1");

            // 4. Tenancy Breach Cases Template
            data.BreachResults = SheetMapperInbound.GetDataSet<TenancyBreach>(
                FileService.GetInboundDataFilePath(ExcelFileType.TenancyBreachCases_17),
                "Sheet1");

            // 5. Welcome Visits and Permissions Template
            data.WelcomeVisitResults = SheetMapperInbound.GetDataSet<WelcomeVisit>(
                FileService.GetInboundDataFilePath(ExcelFileType.WelcomeVisitsAndPermissions_18),
                "Sheet1");

            return data;
        }

        public static CaseMigrationData GetPropertyComplianceData()
        {
            //        data.AdviceSupportResults = SheetMapperInbound.GetDataSet<ElectricSchedule>(
            //FileService.GetInboundDataFilePath(ExcelFileType.AdviceAndSupportCases_16)
            //, "Sheet1");

            //        data.AdviceSupportResults = SheetMapperInbound.GetDataSet<GasSchedule>(
            //FileService.GetInboundDataFilePath(ExcelFileType.AdviceAndSupportCases_16)
            //, "Sheet1");

            return default;
        }

        public static string GenerateReport(CoreMigrationData data)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("MIGRATION VALIDATION REPORT");
            sb.AppendLine("===========================");
            sb.AppendLine($"Generated: {DateTime.Now:f}");
            sb.AppendLine();

            AppendSection(sb, "Properties", data.PropertyResults);
            AppendSection(sb, "Units", data.UnitResults);
            AppendSection(sb, "Tenancies", data.TenancyResults);
            AppendSection(sb, "Tenants", data.TenantResults);
            AppendSection(sb, "Household Members", data.HouseholdMemberResults);

            return sb.ToString();
        }

        public static Stream ExportFilteredCoreDataAsStream(CoreMigrationData data)
        {
            var memoryStream = new MemoryStream();

            // We do NOT use 'using' for wb here because we need to save it to the stream first.
            // However, the XLWorkbook object itself can be disposed after saving.
            using (var wb = new XLWorkbook())
            {
                // 1. Add Sheets (Filtering for valid data only)
                AddWorksheetFromAttributes(wb, "Property", data.Properties);
                AddWorksheetFromAttributes(wb, "Unit", data.Units);
                AddWorksheetFromAttributes(wb, "Tenancy", data.Tenancies);
                AddWorksheetFromAttributes(wb, "Tenant", data.Tenants);
                AddWorksheetFromAttributes(wb, "Household Members", data.HouseholdMembers);

                // 2. Save to the memory stream
                wb.SaveAs(memoryStream);
            }

            // 3. Reset the position so the uploader starts at the beginning
            memoryStream.Seek(0, SeekOrigin.Begin);

            return memoryStream;
        }

        private static void AddWorksheetFromAttributes<T>(XLWorkbook wb, string sheetName, IEnumerable<T> results)
        {
            var data = results.ToList();

            //var validData = results.Where(r => r.IsValid).Select(r => r.Data).ToList();
            //if (!validData.Any()) return;

            var ws = wb.Worksheets.Add(sheetName);

            // 1. Get properties that have the ExcelHeader attribute
            var type = typeof(T);
            var propMappings = type.GetProperties()
                .Select(p => new
                {
                    Property = p,
                    // Fallback to property name if the attribute is missing
                    Header = p.GetCustomAttribute<ExcelHeaderAttribute>()?.HeaderName ?? p.Name
                })
                .ToList();

            // 2. Write Headers (Row 1)
            for (int i = 0; i < propMappings.Count; i++)
            {
                ws.Cell(1, i + 1).Value = propMappings[i].Header;
            }

            // 3. Write Data (Starting at Row 2)
            // We use InsertData with a projection to ensure values match the header order
            ws.Cell(2, 1).InsertData(data.Select(item =>
                propMappings.Select(m => m.Property.GetValue(item))
            ));

            // 4. Formatting
            var range = ws.Range(1, 1, data.Count + 1, propMappings.Count);
            range.CreateTable(); // Optional: Makes it look like a real 'export' table
            ws.Columns().AdjustToContents();
        }

        public static void ExportFilteredCaseData(string outputFilePath,
            Func<Proceeding, bool> proceedingFilter,
            Func<Abandonment, bool> abandonmentFilter,
            Func<AdviceSupport, bool> adviceFilter,
            Func<TenancyBreach, bool> breachFilter,
            Func<WelcomeVisit, bool> welcomeFilter)
        {
            // 1. Get all data
            var allData = GetAllCaseData();

            using var newWb = new XLWorkbook();

            // 2. Add each filtered collection as a sheet
            AddSheet(newWb,
                "Proceedings",
                allData.ProceedingResults
                    .Where(r => proceedingFilter(r.Record))
                    .Select(r => r.Record),
                ExcelFileType.InitiateProceedings_14,
                1);

            AddSheet(newWb,
                "Abandonments",
                allData.AbandonmentResults
                    .Where(r => abandonmentFilter(r.Record))
                    .Select(r => r.Record),
                ExcelFileType.Abandonments_15,
                1);

            AddSheet(newWb,
                "AdviceSupport",
                allData.AdviceSupportResults
                    .Where(r => adviceFilter(r.Record))
                    .Select(r => r.Record),
                ExcelFileType.AdviceAndSupportCases_16,
                "Sheet1");

            AddSheet(newWb,
                "BreachCases",
                allData.BreachResults
                    .Where(r => breachFilter(r.Record))
                    .Select(r => r.Record),
                ExcelFileType.TenancyBreachCases_17,
                1);

            AddSheet(newWb,
                "WelcomeVisits",
                allData.WelcomeVisitResults
                    .Where(r => welcomeFilter(r.Record))
                    .Select(r => r.Record),
                ExcelFileType.WelcomeVisitsAndPermissions_18,
                1);

            // 3. Save the new workbook
            newWb.SaveAs(outputFilePath);
        }

        private static void AddSheet<T>(XLWorkbook newWb, string newSheetName, IEnumerable<T> records, ExcelFileType templateFileType, object templateSheetId)
        {
            if (records == null || !records.Any()) return;

            using var templateWb = new XLWorkbook(FileService.GetInboundDataFilePath(templateFileType));

            IXLWorksheet templateSheet = templateSheetId is int index
                ? templateWb.Worksheet(index)
                : templateWb.Worksheet(templateSheetId.ToString());

            var headerRow = templateSheet.FirstRowUsed();
            var ws = newWb.Worksheets.Add(newSheetName);

            // Cache the properties of T that have the ExcelHeader attribute
            var typeProperties = typeof(T).GetProperties()
                .Where(p => p.GetCustomAttribute<ExcelHeaderAttribute>() != null)
                .Select(p => new
                {
                    Property = p,
                    Header = p.GetCustomAttribute<ExcelHeaderAttribute>().HeaderName
                }).ToList();

            int targetCol = 1;
            var columnMappings = new List<(int TargetColumnIndex, PropertyInfo Property)>();

            foreach (var cell in headerRow.CellsUsed())
            {
                // Skip hidden columns
                if (templateSheet.Column(cell.Address.ColumnNumber).IsHidden) continue;

                var headerValue = cell.Value.ToString().Trim();
                ws.Cell(1, targetCol).Value = headerValue;

                // Match the Excel header to the Attribute value
                var match = typeProperties.FirstOrDefault(p => p.Header.Equals(headerValue, StringComparison.OrdinalIgnoreCase));

                if (match != null)
                {
                    columnMappings.Add((targetCol, match.Property));
                }

                targetCol++;
            }

            // Write Data
            int row = 2;
            foreach (var record in records)
            {
                foreach (var mapping in columnMappings)
                {
                    var value = mapping.Property.GetValue(record);
                    var cell = ws.Cell(row, mapping.TargetColumnIndex);

                    if (value is DateTime dt)
                    {
                        cell.SetValue(dt);
                        cell.Style.DateFormat.Format = "dd/mm/yyyy";
                    }
                    else
                    {
                        cell.SetValue(XLCellValue.FromObject(value ?? string.Empty));
                    }
                }
                row++;
            }
        }

        private static void AppendSection<T>(System.Text.StringBuilder sb, string title, List<RowValidationResult<T>> results)
        {
            var failedRows = results.Where(r => r.Errors.Any()).ToList();
            sb.AppendLine($"{title}: {results.Count} processed, {failedRows.Count} errors.");

            foreach (var row in failedRows)
            {
                sb.AppendLine($"  [Row {row.RowNumber}]: {string.Join(", ", row.Errors)}");
            }
            sb.AppendLine();
        }


    }
}