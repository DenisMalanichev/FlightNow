using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Oblik_polotiv
{
    public class FlightsReader
    {
        public List<Flight> flights = new List<Flight>();
        public FlightsReader(string cls)
        {           
            string[] lines = System.IO.File.ReadAllLines("FlightsInfo.txt");
            
            for (int i = 0; i < lines.Count(); i += 2)
            {
                flights.Add(new Flight(new Direction(lines[i], lines[++i], lines[++i], lines[++i], lines[++i], lines[++i]),
                    DateTime.Parse(lines[++i], CultureInfo.InvariantCulture), DateTime.Parse(lines[++i], CultureInfo.InvariantCulture),
                    lines[++i], cls, int.Parse(lines[++i]), new List<Pilot>{ new Pilot(lines[++i], int.Parse(lines[++i])),
                    new Pilot(lines[++i], int.Parse(lines[++i]))}));
            }
            for (int i = 0; i < flights.Count(); i++)
            {
                System.Console.WriteLine(flights[i]);
            }
        }
    }
}
