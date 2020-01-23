using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorMethodTest
    {
        
        [TestMethod]
        public void addMethodTest1()
        {
            int expected = 5;
            int actual = Calculator.CalculatorMethods.add(1, 4);

            Assert.AreEqual(expected, actual);

            expected = -2;
            actual = Calculator.CalculatorMethods.add(Int32.MaxValue, Int32.MaxValue);

            Assert.AreEqual(expected, actual);
        }

        public void addMethodTest2()
        {
            int expected;
            int actual;

            expected = -2;
            actual = Calculator.CalculatorMethods.add(Int32.MaxValue, Int32.MaxValue);

            Assert.AreEqual(expected, actual);
        }

        public void subtractMethodTest()
        {
            int expected = -1;
            int actual = Calculator.CalculatorMethods.subtract(1, 2);

            Assert.AreEqual(expected, actual);
        }

        public void multiplyMethodTest()
        {
            int expected = 2;
            int actual = Calculator.CalculatorMethods.multiply(1, 2);

            Assert.AreEqual(expected, actual);
        }

        public void divisionMethodTest()
        {
            double expected = 0.5;
            double actual = Calculator.CalculatorMethods.divide(1, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}
