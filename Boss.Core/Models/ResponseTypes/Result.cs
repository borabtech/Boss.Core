namespace Boss.Core.Models.ResponseTypes;
public record Result<T>
{
    public bool Status { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }
}