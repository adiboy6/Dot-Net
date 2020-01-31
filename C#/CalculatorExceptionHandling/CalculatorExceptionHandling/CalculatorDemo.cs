using System;

namespace CalculatorExceptionHandling
{
    class CalculatorDemo
    {
        static void Main(string[] args)
        {
            CalculatorMethods calculatorMethods = new CalculatorMethods();

            try
            {
                int ans = calculatorMethods.add(1,2);

                Console.WriteLine("Addition of two numbers is " + ans);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                int ans = calculatorMethods.add(int.MaxValue,int.MinValue);

                Console.WriteLine("Addition of two numbers is " + ans);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                int ans = calculatorMethods.add(int.MaxValue, int.MaxValue);

                Console.WriteLine("Addition of two numbers is " + ans);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
