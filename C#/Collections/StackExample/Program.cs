using System;
using System.Collections;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fllows FILO or LIFO
            Stack stack = new Stack();

            //pushing(adding) elements
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            stack.Push("E");

            Console.WriteLine("The topmost element of stack is {0}", stack.Peek());

            Console.WriteLine("Size of Stack is {0}\n", stack.Count);

            //if popped, then element is removed and returned
            while (stack.Count != 0)
                Console.WriteLine(stack.Pop());

            Console.ReadKey();
        }
    }
}
