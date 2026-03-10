using System;
using System.Collections.Generic;
using System.Text;

namespace day7Tests.Green
{
    public class Order
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        public string CustomerName { get; set; }

        public string CustomerMail { get; set; }

        public string DiscountApplied { get; set; }

        public void CalculateTotal()
        {
            TotalPrice = Quantity * Product.Price;
        }
    }
}
