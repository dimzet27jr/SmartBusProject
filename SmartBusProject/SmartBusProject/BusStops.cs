using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBusProject
{
    public class BusStops
    {
        public string name { get; set; }
        public List<Restaurants> Restaurants { get; set; }

        public BusStops (string name)
        {
            this.name = name;
            this.Restaurants = new List<Restaurants> ();
        }

        public void AddRestaurant(Restaurants restaurants)
        {
            Restaurants.Add(restaurants);
        }
    }
}
