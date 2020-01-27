using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculatorMethods : ICalculatorMethods
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int subtract(int a, int b)
        {
            return a - b;
        }
        public int multiply(int a, int b)
        {
            return a * b;
        }
        public double divide(double a, double b)
        {
            if (b == 0.0f)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
}
