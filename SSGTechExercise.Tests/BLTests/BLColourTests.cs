using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSGTechExercise.BL;

namespace SSGTechExercise.Tests.BLTests
{
    [TestClass]
    public class BLColourTests
    {
        [TestMethod]
        public void TwoNamesProduceTwoColours()
        {
            String firstColour;
            String secondColour;
            Colour cl = new Colour();

            firstColour = cl.getRandomColour("Ian Baker");
            secondColour = cl.getRandomColour("Elaine Jones");

            Assert.AreNotEqual(firstColour, secondColour);
        }
        [TestMethod]
        public void SameNamesProduceTwoColours()
        {
            String firstColour;
            String secondColour;
            Colour cl = new Colour();

            firstColour = cl.getRandomColour("Ian Baker");
            secondColour = cl.getRandomColour("Ian Baker");

            Assert.AreEqual(firstColour, secondColour);
        }

    }
}
