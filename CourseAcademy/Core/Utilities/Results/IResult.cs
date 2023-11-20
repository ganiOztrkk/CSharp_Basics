namespace Core.Utilities.Results;

public interface IResult // void dönen metotlar için geri dönüş türü olarak kullanacağız.
{
    public bool Success { get; }
    public string? Message { get; }
}