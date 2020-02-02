using System;

namespace CalculatorExceptionHandling
{
    class CalculatorDemo
    {
        public static int string_to_int(string raw_number)
        {
            int number;

            if (raw_number.Contains("."))
                throw new CustomException("Invalid format");

            number = Convert.ToInt32(raw_number);
            return number;
        }

        static void Main(string[] args)
        {
            CalculatorMethods calculatorMethods = new CalculatorMethods();

            Console.WriteLine("Enter two integer numbers:");

            try
            { 
                int number1 = string_to_int(Console.ReadLine());
            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }

            try
            {
                int number2 = string_to_int(Console.ReadLine());
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }

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
