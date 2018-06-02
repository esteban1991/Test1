using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class CRowGeneratorYellowLamp : CRowGenerator
    {
        public override string convertTime(string aTime)
        {
            if (Convert.ToInt32(aTime) % 2 == 0) return "Y";
            return "O";
        }
    }
}
