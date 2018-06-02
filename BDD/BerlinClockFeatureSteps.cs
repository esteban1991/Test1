using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;

namespace BerlinClock
{
    [Binding]
    public class TheBerlinClockSteps
    {
        //private ITimeConverter berlinClock = new ITimeConverter();
        private string theTime;


        public ITimeConverter BerlinClock {  get => this.BerlinClock; set => this.BerlinClock = value;  }

        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            theTime = time;
        }
        
        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {

            try
            {

                var arclock = new CberlinClock();
                Assert.AreEqual(arclock.Generate(Convert.ToDateTime(theTime)), theExpectedBerlinClockOutput);
              
            }
            catch (Exception ex) { throw ex; }
        }

    }
}
