using System;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Works similar to System.Collection.Stack except that it works on Generic
            Stack<int> int_stack = new Stack<int>();

            int_stack.Push(1);
            int_stack.Push(2);
            int_stack.Push(3);
            int_stack.Push(4);
            int_stack.Push(5);

            //Top element of Stack
            Console.WriteLine("Top element of the Stack is " + int_stack.Peek());

            Console.WriteLine("Show the list");
            while (int_stack.Count != 0)
                Console.WriteLine(int_stack.Pop());

        }
    }
}
