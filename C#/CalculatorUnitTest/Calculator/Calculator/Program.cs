using System;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            ICalculatorMethods calculatorMethods = new CalculatorMethods();

            int addition_ans = calculatorMethods.add(Int32.MinValue, Int32.MinValue);

            //Sample Run
            Console.WriteLine(addition_ans);


            int subtraction_ans = calculatorMethods.subtract(Int32.MaxValue, Int32.MaxValue);
            
            //Sample Run
            //Console.WriteLine(subtraction_ans);


            double division_ans = calculatorMethods.divide(22, 7);
            
            //Sample Run
            Console.WriteLine(division_ans);

            Console.ReadKey();
        }
    }
}
