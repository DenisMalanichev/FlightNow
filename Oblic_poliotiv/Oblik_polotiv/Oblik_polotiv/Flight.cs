using System;
using System.Collections.Generic;

namespace Oblik_polotiv
{
    public class Flight
    {
        public string from_Country { get; }
        public string from_City { get; }
        public string from_Airport { get; }
        public string to_Country { get; }
        public string to_City { get; }
        public string to_Airport { get; }
        public int id { get; }
        public DateTime depart { get; }
        public DateTime arrive { get; }
        public string carrier { get; }
        public string cls { get; }
        public int from_Price { get; }
        public List<String> pilots { get; }

        public Flight(string f_Country, string f_City, string f_Airport, string t_Country, string t_City, 
            string t_Airport, DateTime dep, DateTime arr, string carr, string cla, int f_Price, List<String> pilots)
        {
            from_Country = f_Country;
            from_City = f_City;
            from_Airport = f_Airport;
            to_Country = t_Country;
            to_City = t_City;
            to_Airport = t_Airport;
            depart = dep;
            arrive = arr;
            carrier = carr;
            id = form_ID();
            cls = cla;
            from_Price = f_Price;
            this.pilots = pilots;
        }

        public override string ToString()
        {
            return "№" + id + " " + carrier + " " + from_City + "( " + from_Country + " ) - " 
                + to_City + "( " + to_Country + " ) "  + depart + " : " + arrive;
        }
        private int form_ID()
        {
            int identificator = 0;
            foreach (char ch in (from_Airport + from_City + from_Country + to_Airport + to_City + to_Country))
                identificator += ch*ch;
            
            return (identificator % 1000000000);

        }
    }   
      
}
