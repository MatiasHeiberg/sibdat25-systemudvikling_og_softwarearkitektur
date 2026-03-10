using day7.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace day7Tests.Green
{
    public class ConsoleUI
    {
        private readonly OrderService _orderService;
    

        public ConsoleUI(OrderService service)
        {
            _orderService = service;
        }

        public void Run()
        {
            Console.WriteLine("=== Butik (Step 4: Rabatter) ===\n");

            Console.Write("Dit navn: ");
            string customerName = Console.ReadLine()!;

            Console.Write("Din email: ");
            string customerEmail = Console.ReadLine()!;

            Console.Write("Produktnavn: ");
            string productName = Console.ReadLine()!;

            Console.Write("Pris: ");
            decimal price = decimal.Parse(Console.ReadLine()!);

            Console.Write("Antal: ");
            int quantity = int.Parse(Console.ReadLine()!);

            Console.WriteLine("\nVaelg rabat:");
            Console.WriteLine("1. Ingen rabat");
            Console.WriteLine("2. Studenterrabat (15%)");
            Console.WriteLine("3. Seniorrabat (10%)");
            Console.WriteLine("4. Medarbejderrabat (200 kr.)");
            Console.Write("Valg: ");
            string discountChoice = Console.ReadLine()!;

            IDiscountStrategy discountType = discountChoice switch
            {
                "2" => new StudentDiscount(),
                "3" => new SeniorDiscount(),
                "4" => new EmployeeDiscount(),
                _ => new NoDiscount()
            };

            var context = new OrderContext
            {
                ProductName = productName,
                ProductPrice = price,
                Quantity = quantity,
                CustomerName = customerName,
                CustomerEmail = customerEmail,
                DiscountType = discountType
            };

            // Se alle de parametre! Det er svært at holde styr på.
            var order = _orderService.CreateOrder(context, discountType);

            Console.WriteLine($"\nOrdre til {order.CustomerName}:");
            Console.WriteLine($"  {order.Quantity}x {order.Product.Name}");
            Console.WriteLine($"  Rabat: {order.DiscountApplied}");
            Console.WriteLine($"  Total: {order.TotalPrice} kr.");
        }
    }
}
