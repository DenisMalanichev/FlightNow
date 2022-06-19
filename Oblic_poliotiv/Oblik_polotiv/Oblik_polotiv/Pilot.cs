using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblik_polotiv
{
    public class Pilot
    {
        public string Fullname;
        public int ExperienceHours;
        public Pilot(string Fullname, int ExperienceHours)
        {
            this.Fullname = Fullname;
            this.ExperienceHours = ExperienceHours;
        }
        public override string ToString()
        {
            return Fullname + " (" + ExperienceHours + "h)";
        }
    }
}
