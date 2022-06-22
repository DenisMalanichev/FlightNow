using System;
using System.Collections.Generic;

namespace Oblik_polotiv
{
    public class Flight
    {        
        public int id;
        public DateTime depart;
        public DateTime arrive;
        public string carrier;
        public string cls;
        public int from_Price;
        public List<Pilot> pilots;
        public Direction direction;

        public Flight(Direction direction, DateTime dep, DateTime arr, string carr, string cla, int f_Price, List<Pilot> pilots)
        {       
            this.direction = direction;
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
            return "№" + id + " " + carrier + " " + direction.from_City + "( " + direction.from_Country + " ) - " 
                + direction.to_City + "( " + direction.to_Country + " ) "  + depart + " : " + arrive;
        }
        private int form_ID()
        {
            int identificator = 0;
            foreach (char ch in (direction.from_Airport + direction.from_City + direction.from_Country 
                + direction.to_Airport + direction.to_City + direction.to_Country))
                identificator += ch*ch;
            
            return (identificator % 1000000000);
        }
    }   
      
}
