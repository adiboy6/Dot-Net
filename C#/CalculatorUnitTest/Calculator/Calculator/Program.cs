using System;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            int addition_ans = CalculatorMethods.add(Int32.MinValue, Int32.MinValue);

            //Sample Run
            Console.WriteLine(addition_ans);


            int subtraction_ans = CalculatorMethods.subtract(Int32.MaxValue, Int32.MaxValue);
            
            //Sample Run
            Console.WriteLine(subtraction_ans);


            double division_ans = CalculatorMethods.divide(1, 2);
            
            //Sample Run
            Console.WriteLine(division_ans);
        }
    }
}
