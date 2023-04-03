using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering_a_pizza
{
    public class Аccessories
    {
        public int HotPappersPrice { get; set; }
        public int ExtraCheesePrice { get; set; }
        public int KetchapPrice { get; set; }

        public Аccessories()
        {
            HotPappersPrice = 40;
            ExtraCheesePrice = 30;
            KetchapPrice = 20;
        }
    }
}
