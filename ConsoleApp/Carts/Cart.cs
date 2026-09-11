using ConsoleApp.Products;
namespace ConsoleApp.Carts;

public class Cart {
    private readonly List<Product> _products = new();
    public List<Product> Products => _products;

    public void Add(Product product, int quantity) {
        if (product.Quantity < quantity) return;
        _products.Add(product);
        product.Quantity -= quantity;
    }
    
    public void Checkout() {
        double totalPrice = 0;
        double totalWeight = 0;
        foreach(Product product in _products){
            totalPrice += product.Price;
            
        }
    }
}
