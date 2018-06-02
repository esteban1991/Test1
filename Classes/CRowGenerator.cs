using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public abstract class CRowGenerator : ITimeConverter
    {

        protected char Smaller(int value, int valueToCompare, char trueReturnChar = 'R', char falseReturnChar = 'O')
        {
            if (value < valueToCompare) return falseReturnChar;
            return trueReturnChar;
        }


        public abstract string convertTime(string aTime);
        
    }
}
