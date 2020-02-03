using System;

namespace CalculatorExceptionHandling
{
    class CalculatorDemo
    {
        public static int string_to_integer()
        {
            int number = 0;

            while (true)
            {
                string raw_number = Console.ReadLine();
                try
                {
                    if (raw_number.Contains("."))
                        throw new CustomException("Float value is not allowed");
                    number = Convert.ToInt32(raw_number);
                    return number;
                }
                catch (CustomException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again!");
                }
                catch (OverflowException)
                {
                    throw new OverflowException("Number should be within the range of integer");
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }

        public static int input()
        {
            int number;
            while (true)
            {
                Console.WriteLine("Enter a number");
                try
                {
                    number = string_to_integer();
                    break;
                }
                catch (CustomException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again!");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again!");
                }
            }
            return number;
        }

        public static void selectOption(int number1, int number2)
        {
            CalculatorMethods calculatorMethods = new CalculatorMethods();

            Console.WriteLine("Enter the option:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Addition of two numbers:");
                        Console.WriteLine(calculatorMethods.add(number1, number2));
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Subtraction of two numbers:");
                        Console.WriteLine(calculatorMethods.subtract(number1, number2));

                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Multiplicaion of two numbers:");
                        Console.WriteLine(calculatorMethods.multiply(number1, number2));
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Division of two numbers:");
                        Console.WriteLine(calculatorMethods.divide(number1, number2));
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Wrong Option Selected");
                    break;
            }
        }

        static void Main(string[] args)
        {
            int number1 = input();
            int number2 = input();

            selectOption(number1, number2);

        }
    }
}
