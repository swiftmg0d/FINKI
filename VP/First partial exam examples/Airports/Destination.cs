using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports
{
    public class Destination
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public int Price { get; set; }

        public Destination(string name, int length, int price)
        {
            Name = name;
            Length = length;
            Price = price;
        }

        public Destination()
        {
        }

        public override string ToString()
        {
            return $"{Name}  {Length}km - {Price} EUR";
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
