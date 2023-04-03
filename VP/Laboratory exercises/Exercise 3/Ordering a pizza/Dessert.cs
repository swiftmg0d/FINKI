using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering_a_pizza
{
    public class Dessert
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Dessert(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public Dessert()
        {
        }

        public override string ToString() {
            return $"{Name}";
        }
    }
}
