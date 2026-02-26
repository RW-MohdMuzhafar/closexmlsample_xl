using clarion.housing.console.migration.Models;

namespace clarion.housing.console.migration.Services
{
    internal class FileService
    {
        private static string _coreDataPath = @"C:\GriffinDataLoad\DataRoom\Data Templates\Data Templates";

        private static List<string> _bulkFilePaths =
        [
            @"C:\GriffinDataLoad\Jill\Lennon Court\Bulk Sample"
        ];

        private static List<string> _coreDataFilePaths =
        [
            @"C:\GriffinDataLoad\Gill\Bedford, Bedford Central & Luton"
        ];

        private static readonly Dictionary<ExcelFileType, string> FileNameTokens =
            new()
            {
                { ExcelFileType.CoreData_1, "coredatatemplate.xlsx" },
                { ExcelFileType.RepairsHistory_2, "repairshistorytemplate.xlsx" },
                { ExcelFileType.InsuranceHistory_3, "insurancehistorytemplate.xlsx" },
                { ExcelFileType.HousingBenefitPaymentsAndTransactions_4, "hbpaymentsandtransactionstemplate.xlsx" },
                { ExcelFileType.VoidReport_5, "voidreporttemplate.xlsx" },
                { ExcelFileType.GasSchedule_6, "gasscheduletemplate.xlsx" },
                { ExcelFileType.ElectricSchedule_7, "electricscheduletemplate.xlsx" },
                { ExcelFileType.OpenComplaints_8, "opencomplaintstemplate.xlsx" },
                { ExcelFileType.AssetComponentData_9, "assetcomponentdatatemplate.xlsx" },
                { ExcelFileType.CustomerBalancesAndActiveCases_10, "customerbalancesandactivecasestemplate.xlsx" },
                { ExcelFileType.SapRatings_11, "sapratingstemplate.xlsx" },
                { ExcelFileType.FullRdSap_12, "fullrdsaptemplate.xlsx" },
                { ExcelFileType.AidsAndAdaptations_13, "aidsandadaptationstemplate.xlsx" },
                { ExcelFileType.InitiateProceedings_14, "initiateproceedingstemplate.xlsx" },
                { ExcelFileType.Abandonments_15, "abandonmentstemplate.xlsx" },
                { ExcelFileType.AdviceAndSupportCases_16, "adviceandsupportcasestemplate.xlsx" },
                { ExcelFileType.TenancyBreachCases_17, "tenancybreachcasestemplate.xlsx" },
                { ExcelFileType.WelcomeVisitsAndPermissions_18, "welcomevisitsandpermissionstemplate.xlsx" },
                { ExcelFileType.WorksInProgress_19, "worksinprogresstemplate.xlsx" }
            };


        public static IEnumerable<FileInfo> GetInboundCoreDataFiles()
        {
            foreach (var filePath in _coreDataFilePaths)
            {
                var directoryInfo = new DirectoryInfo(filePath);

                if (!directoryInfo.Exists)
                    continue;

                foreach (var file in directoryInfo.GetFiles())
                    yield return file;
            }
        }

        public static string GetInboundDataFilePath(ExcelFileType fileType)
        {
            if (!FileNameTokens.TryGetValue(fileType, out var token))
            {
                throw new ArgumentOutOfRangeException(nameof(fileType), fileType, "Unsupported Excel file type");
            }

            return new DirectoryInfo(_coreDataPath)
                .GetFiles()
                .Single(f =>
                    f.Name.ToLower().Replace(" ", "").Contains(token) &&
                    !f.Name.Contains("~")).FullName;
        }



        public FileService() { }


        public List<FileInfo> GetFilesForCopy()
        {

            return default;
        }

        public List<FileInfo> GetExcelFilesForTransform()
        {
            return default;
        }
    }
}
