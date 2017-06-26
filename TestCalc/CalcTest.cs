using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReactCalc;

namespace TestCalc
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {
            var calc = new Calc();
            var x = calc.Sum(1, 2);

            Assert.AreEqual(x, 3);
            Assert.AreEqual(calc.Sum(0, 0), 0);
            Assert.AreEqual(calc.Sum(-1, 2), 1);
            Assert.AreEqual(calc.Sum(3, 3), 3);
        }

        [TestMethod]
        public void TestPow()
        {
        }
        [TestMethod]
        public void TestDiv()
        {
            var calc = new Calc();
            var x = calc.Div(2, 2);
            var y = calc.Div(2, 0);
            Assert.AreEqual(x, 1);
            Assert.AreEqual(y, double.PositiveInfinity);
        }
        [TestMethod]
        public void TestSqrt()
        {
        }

        [TestMethod]
        public void TestDivide()
        {
        }
    }
}