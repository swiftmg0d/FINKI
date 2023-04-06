using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
    public class Lap
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Lap()
        {
        }

        public Lap(int minutes, int seconds)
        {
            Minutes = minutes;
            Seconds = seconds;
        }

        public override string ToString()
        {
            return $"{Minutes}:{Seconds}";
        }
        public int GetFullTime()
        {
            return Minutes*60+Seconds;
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
