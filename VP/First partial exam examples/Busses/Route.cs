using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busses
{
    public class Route
    {
        public string Destination { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Price   { get; set; }
        public Route() { }

        public Route(string destination, int hours, int minutes, int price)
        {
            Destination = destination;
            Hours = hours;
            Minutes = minutes;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Hours}:{Minutes} - {Destination} - {Price} Ден";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
