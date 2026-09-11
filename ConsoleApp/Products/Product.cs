namespace ConsoleApp.Products;

public class Product {
    public string? Name { get; init; }
    public double Price {
        get;
        set {
            if (value < 0) return;
            field = value;
        }
    }

    public int Quantity {
        get;
        set {
            if(value < 0) return;
            field = value;
        }
    }

    public Product(string? name, double price, int quantity) {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}