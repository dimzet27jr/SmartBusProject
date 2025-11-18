using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBusProject
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal TotalPrice
        {
            get
            {
                // Υπολογίζουμε ασφαλώς σε decimal
                return Convert.ToDecimal(Product.getPrice()) * Quantity;
            }
        }
    }
}
