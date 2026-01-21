using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBusProject
{
    public class Cafes
    {
        private String name;
        private String address;
        private int minutes;

        public Cafes(string name, string address, int minutes)
        {
            this.name = name;
            this.address = address;
            this.minutes = minutes;
        }

        public String getName() {  return name; }
        public String getAddress() { return address; }
        public int getMinutes() { return minutes; }
    }
}
