namespace ConsoleApp.Products;

public class Tv:Product, IDeliverable {
    public double Weight {
        get;
        init {
            if (value < 0) return;
            field = value;
        }
    }

    string IDeliverable.GetName() {
        return Name ?? "TV";
    }
    public Tv(string? name, double price, int quantity, double weight) : base(name, price, quantity) {
        Name = name;
        Weight = weight;
    }
}