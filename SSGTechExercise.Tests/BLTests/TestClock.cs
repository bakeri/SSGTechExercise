using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSGTechExercise.BL;



namespace SSGTechExercise.Tests.BLTests
{
    public class TestClock:IDate
    {
        private int pyear;
        private int pmonth;
        private int pday;
        public TestClock(int day,int month,int year)
        {
            pyear = year;
            pmonth = month;
            pday = day;
        }

        public DateTime Now { get { return new DateTime(pyear, pmonth, pday, 0, 0, 0); } }
    }
}
