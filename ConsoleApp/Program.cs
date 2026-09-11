using ConsoleApp.Carts;
using ConsoleApp.Products;
namespace ConsoleApp;


public class Program {
    public static void Main() {
        Cart cart = new();
        Tv samsungTv = new Tv("Samsung", 500, 5, 6000);
        Cheese whiteCheese = 
            new Cheese("White Cheese", 50, 10,500 , TimeSpan.FromDays(90));
        ScratchCard card = new ScratchCard("card", 10, 10);
        cart.Add(whiteCheese, 1);
        cart.Add(card, 1);
        cart.Add(samsungTv,2);
    }  

}