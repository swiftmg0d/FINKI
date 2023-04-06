using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
    public class Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsFirstDriver { get; set; }
        public List<Lap> List0fLaps { get; set; }

        public Driver(string name, int age, bool isFirstDriver)
        {
            Name = name;
            Age = age;
            IsFirstDriver = isFirstDriver;
            List0fLaps=new List<Lap>();
        }

        public override string ToString()
        {
            if (IsFirstDriver)
            {
                return $"{Name} ({Age} - F)";
            }
            else
            {
                return $"{Name} ({Age} - S)";
            }
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
