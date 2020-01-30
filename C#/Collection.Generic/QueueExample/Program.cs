using System;
using System.Collections.Generic;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<String> queue = new Queue<string>();

            queue.Enqueue("A");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");
            queue.Enqueue("e");

            //First element is Queue
            Console.WriteLine("First element is " + queue.Peek());

            //Tries wheter the queue still has any elements or not
            while (queue.TryDequeue(out string value))
                Console.WriteLine(value);
        }
    }
}
