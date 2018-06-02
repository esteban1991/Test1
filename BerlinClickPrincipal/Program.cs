using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerlinClock;

namespace BerlinClickPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {

            var theTimeNow = DateTime.Now;
            var clock = new CberlinClock ();
            Console.WriteLine("The berlin clock for {0} is ...\n", theTimeNow.ToString("hh:mm:ss"));
            Console.WriteLine(clock.Generate(theTimeNow));
          

            Console.ReadLine();
        }
    }
}
