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

            // Opgave 2.4
            var payroll = new PayrollSystem();

            payroll.ProcessPayroll("John", "FullTime", 15_000m, 37);
            payroll.ProcessPayroll("Jessi", "PartTime", 15_000m, 37);
            payroll.ProcessPayroll("Claud", "Freelancer", 15_000m, 18);
            payroll.ProcessPayroll("Messi", "FullTime", 15_000m, 45);
        }
    }
}
