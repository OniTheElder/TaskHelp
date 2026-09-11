namespace ConsoleApp.Products;

public interface IExpireable {
    public  DateTime ExpiresAt { get; init; }
    public bool IsExpired { get; }
}