namespace ConsoleApp.Products;

public interface IDeliverable {
    // var targetObjects = objectList.OfType<IMyInterface>().ToList();
    public double Weight { get; init; }
    public double getWeight();
    public string getName();
}