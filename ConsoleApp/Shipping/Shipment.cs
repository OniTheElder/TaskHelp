using ConsoleApp.Carts;
using ConsoleApp.Products;

namespace ConsoleApp.Shipping;

public class Shipment {
    public void PrintShipmentNotice(Cart cart) {
        double totalWeight = 0;
        Console.WriteLine("** Shipment Notice **");
        foreach (var cartItem in cart.Products) {
            if (cartItem.Product is IDeliverable deliverable) {
                totalWeight += deliverable.Weight * cartItem.Quantity;
                Console.WriteLine($"{cartItem.Quantity}X {cartItem.Product.Name}         {deliverable.Weight}g");
            }
        }
        
        Console.WriteLine($"Total weight: {totalWeight/1000}Kg");
    }
}