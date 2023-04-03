using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering_a_pizza
{
    public class Drinks
    {
        public int SodaPrice { get; set; }
        public int JuicePrice { get; set; }
        public int BeerPrice { get; set; }
        public Drinks() {
            SodaPrice = 60;
            JuicePrice = 70;
            BeerPrice = 80;
        }
    }
}
