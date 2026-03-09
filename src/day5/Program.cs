using OrderSystem;

namespace OrderSystem;

public class Program
{
    public static void Main(string[] args)
    {
        new Program().Run();
    }

    public void Run()
    {
        var OrderService = new OrderService(
            new PriceCalculator(), 
            new ConsoleLogger());

        OrderService.CreateOrder("Tastetur", 500, 2);
        OrderService.CreateOrder("Mus", 200, 3);
        OrderService.CreateOrder("Gratis vare", 0, 1);
        OrderService.CreateOrder("Skærm", 1500, 1);
    }
}