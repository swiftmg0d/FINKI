using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering_a_pizza
{
    public class Sizes
    {
 
        public int LargePrice { get; set; }
        public int MediumPrice { get; set;}
        public int SmallPrice { get; set; }

        public Sizes()
        {
            LargePrice = 500;
            MediumPrice = 300;
            SmallPrice = 200;
        }
    }
}
