using ConsoleApp.Products;
namespace ConsoleApp.Carts;

public class CartItem {
    public Product Product { get; init; }
    public int Quantity { get; set; }
    public CartItem(Product product, int quantity) {
        Product = product;
        Quantity = quantity;
    }
}