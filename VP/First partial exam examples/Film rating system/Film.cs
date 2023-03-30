using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_rating_system
{
    public class Film
    {
        public string Name { get; set; }
        public int Year0fRelease { get; set; }
        public List<int> RatingsList { get; set; }
        public double avg {get; set; }

        public Film(string name, int year0fRelease)
        {
            Name = name;
            Year0fRelease = year0fRelease;
            RatingsList=new List<int>();
            avg = 1.0;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return $"{Name} ({Year0fRelease})";
        }
        public void updateAvg()
        {
            if(RatingsList.Count > 0)
            {
                avg = RatingsList.Average();

            }
        }
    }
}
