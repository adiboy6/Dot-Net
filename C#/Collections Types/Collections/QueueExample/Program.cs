using System;
using System.Collections;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //folow FIFO or LILO
            Queue queue = new Queue();

            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            queue.Enqueue("D");

            Console.WriteLine("The topmost element of queue is {0}", queue.Peek());

            Console.WriteLine("Size of Queue is {0}\n", queue.Count);

            //If Dequeued, the topmost element is removed and returned
            while (queue.Count != 0)
                Console.WriteLine(queue.Dequeue());

            Console.ReadKey();
        }
    }
}
