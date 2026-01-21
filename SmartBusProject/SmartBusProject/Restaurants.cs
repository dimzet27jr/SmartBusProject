using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBusProject
{
    public class Restaurants
    {
        public string name {  get; set; }
        public string address { get ; set; }
        public string distance { get; set; }

        public Restaurants(string name, string address, string distance)
        {
            this.name = name;
            this.address = address;
            this.distance = distance;
        }
    }
}
