using ConsoleApp.Products;
namespace ConsoleApp.Carts;

public class Cart {
    private readonly List<CartItem> _products = new();
    public List<CartItem> Products => _products;

    public bool AddItem(Product product, int quantity) {
        if (product.Quantity < quantity) return false;
        foreach (CartItem ci in _products) {
            if (ci.Product.GetType() == product.GetType()) {
                ci.Quantity += quantity;
                return true;
            }
        }
        _products.Add(new CartItem(product, quantity));
        return true;
    }
}
