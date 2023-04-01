using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_cart_system
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public Product(string name, string category, double price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
        public string tString(double times)
        {
            return $"{Name} {times} x {Price} = {times * Price}";
        }
    }
}
