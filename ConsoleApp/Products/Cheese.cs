namespace ConsoleApp.Products;

public class Cheese:Product, IExpireable, IDeliverable {
    public double Weight {
        get;
        init {
            if (value < 0) return;
            field = value;
        }
    }

    public DateTime ExpiresAt { get; init; }
    public bool IsExpired => DateTime.Now > ExpiresAt;

    string IDeliverable.GetName() {
        return Name ?? "Cheese";
    }
    public Cheese(string? name, double price, int quantity, double weight, TimeSpan periodOfValidity) : base(name, price, quantity) {
        ExpiresAt = DateTime.Now +  periodOfValidity;
        Weight = weight;
    }
    
}