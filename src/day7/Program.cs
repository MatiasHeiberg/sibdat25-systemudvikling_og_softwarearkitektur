namespace day7Tests.Green
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger logger = new ConsoleLogger();
            OrderService service = new OrderService(logger);
            ConsoleUI consoleUI = new ConsoleUI(service);
            consoleUI.Run();
        }
    }

}
