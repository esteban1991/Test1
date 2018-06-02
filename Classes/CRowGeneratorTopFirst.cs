using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class CRowGeneratorTopFirst : CRowGenerator
    {
        public override string convertTime(string aTime)
        {
            return String.Format("{3}{2}{1}{0}",
                Smaller(Convert.ToInt32(aTime), 20),
                Smaller(Convert.ToInt32(aTime), 15),
                Smaller(Convert.ToInt32(aTime), 10),
                Smaller(Convert.ToInt32(aTime), 5));
        }
    }
}
