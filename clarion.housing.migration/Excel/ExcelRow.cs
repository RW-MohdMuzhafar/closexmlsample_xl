using ClosedXML.Excel;

public class ExcelRow
{
    private readonly Dictionary<string, IXLCell> _cells;

    public ExcelRow(IXLRow row)
    {
        _cells = row.Worksheet.Row(1)
            .Cells()
            .ToDictionary(c => c.GetString().Trim(), c => row.Cell(c.Address.ColumnNumber));
    }

    public string GetString(string column)
        => _cells.TryGetValue(column, out var c) ? c.GetString() : "";

    public int? GetInt(string column)
        => _cells.TryGetValue(column, out var c) && !c.IsEmpty() ? c.GetValue<int>() : null;

    public DateTime? GetDate(string column)
    {
        if (!_cells.TryGetValue(column, out var c) || c.IsEmpty())
            return null;

        var dateString = c.GetString();
        if (DateTime.TryParse(dateString, new System.Globalization.CultureInfo("en-GB"), System.Globalization.DateTimeStyles.None, out var result))
        {
            return result;
        }

        try
        {
            return c.GetDateTime();
        }
        catch
        {
            return null;
        }
    }

    public bool GetBool(string column)
        => _cells.TryGetValue(column, out var c) && c.GetBoolean();
    public decimal? GetDecimal(string column)
        => _cells.TryGetValue(column, out var c) && !c.IsEmpty() ? c.GetValue<decimal>() : null;
}