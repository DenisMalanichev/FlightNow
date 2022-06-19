using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblik_polotiv
{
    public class City
    {
        public string CityName;
        public List<string> Airports;
        public override string ToString()
        {
            return CityName;
        }
        public List<string> GetAirports(City city)
        {
            return city.Airports;
        }
    }
}
