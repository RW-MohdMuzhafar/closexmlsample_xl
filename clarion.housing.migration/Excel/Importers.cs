using ClosedXML.Excel;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;

public static class Importers
{
    public static List<RowValidationResult<T>> Import<T>(
        IXLWorksheet sheet,
        Func<ExcelRow, T> mapper,
        IValidator<T> validator)
    {
        var results = new List<RowValidationResult<T>>();

        foreach (var row in sheet.RowsUsed().Skip(1))
        {
            var excel = new ExcelRow(row);
            var record = mapper(excel);

            var validation = validator.Validate(record);

            results.Add(new RowValidationResult<T>
            {
                RowNumber = row.RowNumber(),
                Record = record,
                Errors = validation.Errors.Select(e => e.ErrorMessage).ToList()
            });
        }

        return results;
    }
}