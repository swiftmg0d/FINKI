using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busses
{
    public class Bus
    {
        public string Name { get; set; }
        public string Registration { get; set; }
        public bool isLocal { get; set; }
        public List<Route> List0fRoutes { get; set; }
        public Bus() { }

        public Bus(string name, string registration, bool isLocal)
        {
            Name = name;
            Registration = registration;
            this.isLocal = isLocal;
            List0fRoutes = new List<Route>();
        }

        public override string ToString()
        {
            if (isLocal)
            {
                return $"{Name} - {Registration} - L";
            }
            return $"{Name} - {Registration} - M";
        }
    }
}
