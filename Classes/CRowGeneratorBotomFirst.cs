using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    public class CRowGeneratorBotomFirst : CRowGenerator
    {
        public override string convertTime(string aTime)
        {
            return String.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}",
               Smaller(Convert.ToInt32( aTime), 5, 'Y'),
               Smaller(Convert.ToInt32(aTime), 10, 'Y'),
               Smaller(Convert.ToInt32(aTime), 15),
               Smaller(Convert.ToInt32(aTime), 20, 'Y'),
               Smaller(Convert.ToInt32(aTime), 25, 'Y'),
               Smaller(Convert.ToInt32(aTime), 30),
               Smaller(Convert.ToInt32(aTime), 35, 'Y'),
               Smaller(Convert.ToInt32(aTime), 40, 'Y'),
               Smaller(Convert.ToInt32(aTime), 45),
               Smaller(Convert.ToInt32(aTime), 50, 'Y'),
               Smaller(Convert.ToInt32(aTime), 55, 'Y'));
        }
    }
}
