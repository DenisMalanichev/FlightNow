using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblik_polotiv
{
    public class Direction : City
    {
        public string from_Country;
        public string from_City;
        public string from_Airport;
        public string to_Country;
        public string to_City;
        public string to_Airport;
        public Direction(string from_Country, string from_City, string from_Airport,
            string to_Country, string to_City, string to_Airport)
        {
            this.from_Country = from_Country;
            this.from_City = from_City;
            this.from_Airport = from_Airport;
            this.to_Country = to_Country;
            this.to_City = to_City;
            this.to_Airport = to_Airport;
        }
        public override string ToString()
        {
            return from_City + "( " + from_Country + " ) - "
                + to_City + "( " + to_Country + " ) ";
        }
        public Direction GetBackDirection()
        {
            return new Direction(to_Country, to_City, to_Airport, from_Country, from_City, from_Airport);
        }
    }
}
