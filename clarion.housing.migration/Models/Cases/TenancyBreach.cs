using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clarion.housing.console.migration.Models.Cases
{
    public class TenancyBreach
    {
        [ExcelHeader("Name")]
        public string? Name { get; set; }

        [ExcelHeader("Reference")]
        public string? Reference { get; set; }

        [ExcelHeader("Property / Unit")]
        public string? PropertyUnit { get; set; }

        [ExcelHeader("Breach 1")]
        public string? Breach1 { get; set; }

        [ExcelHeader("Breach 2")]
        public string? Breach2 { get; set; }

        [ExcelHeader("Breach 3")]
        public string? Breach3 { get; set; }

        [ExcelHeader("Last Action")]
        public string? LastAction { get; set; }

        [ExcelHeader("Start Date")]
        public DateTime? StartDate { get; set; }

        [ExcelHeader("Modified On")]
        public DateTime? ModifiedOn { get; set; }

        [ExcelHeader("Update")]
        public string? Update { get; set; }
    }
}
