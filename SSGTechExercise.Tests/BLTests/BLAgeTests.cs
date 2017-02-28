using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSGTechExercise.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSGTechExercise.Tests.BLTests
{
    [TestClass]
      public class BLAgeTests
    {
        [TestMethod]
        public void BornInAMonthAfterThisMonth()
        {
            TestClock tstCl = new TestClock(01, 03,2017);
            CustomersBL blayer = new CustomersBL();
            DateTime dob = new DateTime(1969, 7, 9);

            Assert.AreEqual(blayer.calculateAge(dob, tstCl), 47);

        }

        [TestMethod]
        public void BornInAMonthBeforeThisMonth()
        {
            TestClock tstCl = new TestClock(01, 10, 2017);
            CustomersBL blayer = new CustomersBL();
            DateTime dob = new DateTime(1969, 7, 9);

            Assert.AreEqual(blayer.calculateAge(dob, tstCl), 48);

        }
    }
}
