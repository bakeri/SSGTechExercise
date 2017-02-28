using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSGTechExercise.BL
{
    public class RealClock:IDate
    {
        public DateTime Now { get { return DateTime.Now; } }
    }
}