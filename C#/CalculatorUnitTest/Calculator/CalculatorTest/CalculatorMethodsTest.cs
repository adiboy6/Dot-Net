using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTest
{
    [TestClass]
    public sealed class CalculatorMethodsTest
    {

        Calculator.CalculatorMethods calculatorMethods = new Calculator.CalculatorMethods();

        [TestMethod]
        public void addMethodSimpleTest()
        {
            int expected = 5;
            int actual = calculatorMethods.add(1, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addMethodMaxNumbersTest()
        {
            int expected = -2;
            int actual = calculatorMethods.add(Int32.MaxValue, Int32.MaxValue);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addMethodMinNumbersTest()
        {
            int expected = 0;
            int actual = calculatorMethods.add(Int32.MinValue, Int32.MinValue);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void subtractMethodSimpleTest()
        {
            int expected = -1;
            int actual = calculatorMethods.subtract(1, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void multiplyMethodTest()
        {
            int expected = 2;
            int actual = calculatorMethods.multiply(1, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void divisionMethodSimpleTest()
        {
            double expected = 2.3333333333333335;
            double actual = calculatorMethods.divide(7, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void divisionMethodComplexTest()
        {
            double expected = 3.142857142857143;
            double actual = calculatorMethods.divide(22, 7);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void divisionByZeroMethodTest()
        {
            Action action = delegate () { calculatorMethods.divide(1, 0); };

            Assert.ThrowsException<DivideByZeroException>(action);
        }
    }
}
