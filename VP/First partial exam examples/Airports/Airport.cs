using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports
{
    public class Airport
    {
        public string City { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Airport(string city, string name, string code)
        {
            City = city;
            Name = name;
            Code = code;
        }

        public override string ToString()
        {
            return $"{Code} - {Name} - {City}";
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
