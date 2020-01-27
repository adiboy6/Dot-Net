using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface ICalculatorMethods
    {
        int add(int a, int b);
        int subtract(int a, int b);
        int multiply(int a, int b);
        double divide(double a, double b);
    }
}
