using day6.excersise2;
using day6.excersise3;

namespace day6
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Opgave 2.2
            new OrderService(new EmailSender()).SendConfirmation("mor");

            // Opgave 2.3
            new Transport(new CombustionEngine(), false);
            new Transport(new CombustionEngine(), true);
            new Transport(new ElectricEngine(), false);
            new Transport(new ElectricEngine(), true);
            new Transport(new HybridEngine(), true);
        }
    }
}
