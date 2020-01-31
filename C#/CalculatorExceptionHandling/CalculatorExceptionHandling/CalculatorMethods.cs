using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorExceptionHandling
{
    class CalculatorMethods
    {
        public int add(int a, int b)
        {
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                throw new OverflowException("Addition Overflow");
            return a + b;
        }

        public int subtract(int a, int b)
        {
            if ((a == int.MinValue && b < 0) || (b == int.MinValue && a < 0))
                throw new OverflowException("Subtraction Overflow");
            return a - b;
        }
        public int multiply(int a, int b)
        {
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                throw new OverflowException("Multiplication Overflow");
            return a * b;
        }
        public double divide(double a, double b)
        {
            if (a == double.MaxValue || a == double.MinValue || b == double.MaxValue || b == double.MinValue)
                throw new OverflowException("Division Overflow");
            if((a != 0 && b==0) || (a == 0 && b != 0))
                throw new 
            if (b == 0.0f)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
}
