using ConsoleApp.Carts;
using ConsoleApp.Products;
using ConsoleApp.Customers;
using ConsoleApp.Shipping;
using ConsoleApp.StoreHelpers;
namespace ConsoleApp;


public class Program {
    public static void Main() {
        Cart cart = new();
        Tv samsungTv = new Tv("Samsung", 500, 5, 6000);
        Cheese whiteCheese = 
            new Cheese("White Cheese", 50, 10,500 , TimeSpan.FromDays(90));
        ScratchCard card = new ScratchCard("card", 10, 10);
        cart.AddItem(whiteCheese, 2);
        cart.AddItem(samsungTv, 3);
        cart.AddItem(card, 1);
        cart.AddItem(samsungTv, 4);
        Shipment shipment = new Shipment();
        shipment.PrintShipmentNotice(cart);
        Checkout.CheckOut(cart);
    }  

}