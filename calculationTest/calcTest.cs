using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rondAlgo;
using System.Collections.Generic;

namespace calculationTest
{
    [TestClass]
    public class calcTest
    {
        [TestMethod]
        public void Test_Calculate_Rectangular()
        {
            //test skupnega števila in dveh pozicij
            //skupaj 392 po rectangular
            //[58] vrsta 2, pozicija 3 xy -> 34,13
            //[115] vrsta 3, pozicija 4 xy -> 43,28

            //Arrange
            int length = 531;
            int width = 82;
            int radius = 3;
            int minLeftDistance = 13;
            int minTopDistance = 7;
            int minMiddleDistance = 3;
            int expected = 392;

            //Act
            Calculation cal = new Calculation();
            List<Rond> result = cal.Calculate(length, width, radius, minTopDistance, minLeftDistance, minMiddleDistance);

            //Assert
            Assert.AreEqual(expected, result.Count);
            if (expected == result.Count)
            { 
                Assert.AreEqual(34, result[58].posX);
                Assert.AreEqual(19, result[58].posY);
                Assert.AreEqual(43, result[115].posX);
                Assert.AreEqual(28, result[115].posY);
            }
        }

        [TestMethod]
        public void Test_Calculate_Triangular()
        {
            //test skupnega števila in dveh pozicij
            //skupaj 392 po triangular
            //[1] vrsta 1, pozicija 2 xy -> 82,28
            //[9] vrsta 2, pozicija 1 xy -> 55,75

            //Arrange
            int length = 504;
            int width = 104;
            int radius = 26;
            int minLeftDistance = 2;
            int minTopDistance = 2;
            int minMiddleDistance = 1;
            int expected = 17;

            //Act
            Calculation cal = new Calculation();
            List<Rond> result = cal.Calculate(length, width, radius, minTopDistance, minLeftDistance, minMiddleDistance);

            //Assert
            if (expected == result.Count)
            {
                Assert.AreEqual(expected, result.Count);
                Assert.AreEqual(82, result[1].posX);
                Assert.AreEqual(28, result[1].posY);
                Assert.AreEqual(55, result[9].posX);
                Assert.AreEqual(75, result[9].posY);
            }
        }
    }
}
