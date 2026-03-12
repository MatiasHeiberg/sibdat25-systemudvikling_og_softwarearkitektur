using day7.PizzaDecorator;

namespace day7Tests.Green
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConsoleLogger logger = new ConsoleLogger();
            //OrderService service = new OrderService(logger);
            //ConsoleUI consoleUI = new ConsoleUI(service);
            //consoleUI.Run();

            IPizza pizza = new Margherita();
            pizza = new BaconDecorator(pizza);
            pizza = new ExtraCheeseDecorator(pizza);

            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.CalculatePrice() + " kr");
        }
    }

}
