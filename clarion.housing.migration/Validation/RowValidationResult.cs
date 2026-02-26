public class RowValidationResult<T>
{
    public int RowNumber { get; set; }
    public T Record { get; set; } = default!;
    public List<string> Errors { get; set; } = new();
    public bool IsValid => Errors.Count == 0;
}