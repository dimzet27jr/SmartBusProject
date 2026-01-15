using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBusProject
{
    public class Product
    {
        private String name;
        private double price;

        public Product (string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public String getName() {  return name; }

        public double getPrice() { return price; }
    }
}
