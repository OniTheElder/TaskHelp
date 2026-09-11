using ConsoleApp.Carts;
using ConsoleApp.Products;
namespace ConsoleApp.StoreHelpers;

public static class Checkout {
    public static void CheckOut(Cart cart) {
        double subtotalPrice = 0;
        Console.WriteLine("** Shipment Notice **");
        foreach (CartItem ci in cart.Products) {
            subtotalPrice += ci.Product.Price * ci.Quantity;
            Console.WriteLine($"{ci.Quantity}X {ci.Product.Name}       {ci.Product.Price:C}$");
        }

        Console.WriteLine($"--------------------------");
        Console.WriteLine($"Subtotal        {subtotalPrice:C}");
        Console.WriteLine($"Shipping        $30");
        Console.WriteLine($"Amount          {subtotalPrice + 30:C}");
    }
}