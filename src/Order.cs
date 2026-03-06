using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Order
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public Order(Product product, int quantity, decimal totalPrice)
        {
            Product = product;
            Quantity = quantity;
            TotalPrice = totalPrice;
        }
    }
}

