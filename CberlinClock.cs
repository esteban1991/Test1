using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerlinClock.Classes;

namespace BerlinClock
{
    public class CberlinClock
    {
        private readonly ITimeConverter _topFirstRow;
        private readonly ITimeConverter _topSecondRow;
        private readonly ITimeConverter _bottomFirstRow;
        private readonly ITimeConverter _bottomSecondRow;
        private readonly ITimeConverter _lampGenerator;
        private readonly CValueBiggest _hourBiggestFit;
        private readonly CValueBiggest _minuteBiggestFit;
  

        public CberlinClock() : this(
            new CRowGeneratorTopFirst(),
            new CRowGeneratorTopSecond(),
            new CRowGeneratorBotomFirst(),
            new CRowGeneratorBottomSecond(),
            new CRowGeneratorYellowLamp())
        {
        }

        public CberlinClock(ITimeConverter topFirstRow, ITimeConverter topSecondRow, ITimeConverter bottomFirstRow, ITimeConverter bottomSecondRow, ITimeConverter lampGenerator)
        {
            _topFirstRow = topFirstRow;
            _topSecondRow = topSecondRow;
            _bottomFirstRow = bottomFirstRow;
            _bottomSecondRow = bottomSecondRow;
            _lampGenerator = lampGenerator;
            _hourBiggestFit = new CValueBiggest(new List<int> { 5, 10, 15, 20 });
            _minuteBiggestFit = new CValueBiggest(new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 35, 50, 55 });
        }


        public string Generate(DateTime timeOfDay)

        {
            
                return ConvertTime(timeOfDay.Hour, timeOfDay.Minute, timeOfDay.Second);
          
       
        }
      
       
             

        public string ConvertTime(int hour, int minute, int second)
        {
            int hoursFirstRow =hour;
            int hoursSecondRow = hour - _hourBiggestFit.GetFit(hour);

            int minutesFirstRow = minute;
            int minutesSecondRow = minute - _minuteBiggestFit.GetFit(minute);

         return string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}", _lampGenerator.convertTime(Convert.ToString(second)), _topFirstRow.convertTime(Convert.ToString(hoursFirstRow)), _topSecondRow.convertTime(Convert.ToString(hoursSecondRow)), _bottomFirstRow.convertTime(Convert.ToString(minutesFirstRow)), _bottomSecondRow.convertTime(Convert.ToString(minutesSecondRow)));

        }
    }
}
