using System;
using System.Collections.Generic;
using System.Linq;


namespace BerlinClock.Classes
{
   public  class CValueBiggest
    {
        private readonly IEnumerable<int> _pivots;

        public CValueBiggest(IEnumerable<int> pivots)
        {
            _pivots = pivots;
        }

        public int GetFit(int value)
        {
            return _pivots.Where(x => x < value).OrderByDescending(x => x).FirstOrDefault();
        }
    }
}
