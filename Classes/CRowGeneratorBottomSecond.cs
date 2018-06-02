using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class CRowGeneratorBottomSecond : CRowGenerator
    {
        public override string convertTime(string aTime)
        {
            return String.Format("{3}{2}{1}{0}",
               Smaller(Convert.ToInt32( aTime), 4, 'Y'),
               Smaller(Convert.ToInt32(aTime), 3, 'Y'),
               Smaller(Convert.ToInt32(aTime), 2, 'Y'),
               Smaller(Convert.ToInt32(aTime), 1, 'Y'));
        }
    }
}
