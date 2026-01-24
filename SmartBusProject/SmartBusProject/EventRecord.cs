using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBusProject
{
    public class EventRecord
    {
        public DateTime Time { get; set; }
        public int Floor { get; set; }
        public int SeatNumber { get; set; }
        public string Item { get; set; }
        public string Importance { get; set; }

        public EventRecord(DateTime time, int floor, int seatNumber, string item, string importance)
        {
            Time = time;
            Floor = floor;
            SeatNumber = seatNumber;
            Item = item;
            Importance = importance;
        }
    }
}
