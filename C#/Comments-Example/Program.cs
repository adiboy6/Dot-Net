using System;

namespace ConsoleApp
{
    /// <summary>
    /// Main class
    /// </summary>
    class Program
    {
        /// <summary>
        /// The Main function.
        /// </summary>
        /// <returns>
        /// Void
        /// </returns>
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.WriteLine("Enter two numbers:");

            /// <value>the <c>number</c> varialbe is used to store the first operand of user input</value>
            number1 = Convert.ToInt32(Console.ReadLine());

            ///<value>the <c>number</c> varialbe is used to store the second operand of user input</value>
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Division(in decimals)\n");

            Console.WriteLine("\nChoose any one:");
            
            ///<value>the <c>option</c> varialbe is used to store the value of selected options from user</value>
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Addition of two numbers:");
                    Console.WriteLine(Calculator.Add(number1,number2));
                    break;
                case 2:
                    Console.WriteLine("Subtraction of two numbers:");
                    Console.WriteLine(Calculator.Subtract(number1, number2));
                    break;
                case 3:
                    Console.WriteLine("Multiplicaion of two numbers:");
                    Console.WriteLine(Calculator.Multiply(number1, number2));
                    break;
                case 4:
                    Console.WriteLine("Division of two numbers:");
                    Console.WriteLine(Calculator.Divide(number1, number2));
                    break;
                case 5:
                    Console.WriteLine("Division of two numbers(in decimals):");
                    Console.WriteLine(Calculator.Divide((double)number1, (double)number2));
                    break;
                default:
                    Console.WriteLine("Wrong Option Selected");
                    break;
            }

            Console.ReadKey();

        }
    }
}
