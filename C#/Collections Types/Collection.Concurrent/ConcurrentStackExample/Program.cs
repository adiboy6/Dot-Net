using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ConcurrentStackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int items = 100;

            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            List<Task> tasks = new List<Task>();

            Action produce_and_consume = delegate ()
            {
                Console.WriteLine($"Task started on {Task.CurrentId}");

                int item;
                for (int i = 0; i < items; i++)
                    stack.Push(i);
                for (int i = 0; i < items; i++)
                    stack.TryPop(out item);

                Console.WriteLine($"Task ended on {Task.CurrentId}");
            };

            for (int num = 0; num < 5; num++)
            {
                tasks.Add(Task.Run(produce_and_consume));
            }

            Task.WaitAll(tasks.ToArray());

            if (stack.IsEmpty)
                Console.WriteLine("Stack is empty");

        }
    }
}
