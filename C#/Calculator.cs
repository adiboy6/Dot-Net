using System;


class Calculator {
    static void Main(String[] args) {
        int number1;
        int number2;
       
        Console.WriteLine("Enter two numbers:\n");
       
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
       
        Console.WriteLine("\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
        
        Console.WriteLine("\nChoose any one:");
        
        int option = Convert.ToInt32(Console.ReadLine());
        
        switch(option)
        {
            case 1:
                Console.WriteLine("Addition of two numbers:");
                Console.WriteLine(number1+number2);
                break;
            case 2:
                Console.WriteLine("Subtraction of two numbers:");
                Console.WriteLine(number1-number2);
                break;
            case 3:
                Console.WriteLine("Multiplicaion of two numbers:");
                Console.WriteLine(number1*number2);
                break;
            case 4:
                Console.WriteLine("Division of two numbers:");
                Console.WriteLine((float)number1/number2);
                break;
            default:
                Console.WriteLine("Wrong Option Selected");
                break;
        }
    }
}