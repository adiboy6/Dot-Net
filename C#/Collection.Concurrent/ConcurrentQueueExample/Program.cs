using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentQueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();

            //Producer
            for (int num = 0; num < 100; num++)
                queue.Enqueue(num);

            if (queue.TryPeek(out int result))
                Console.WriteLine("Topmost elment is {0}", result);

            //Consumer
            Action consume = delegate ()
            {
                while (queue.TryDequeue(out int consumed))
                    Console.WriteLine("Consumed : " + consumed);
            };

            //Similar to List<Task> and Task.WaitAll combined
            Parallel.Invoke(consume, consume);

            if (queue.IsEmpty)
                Console.WriteLine("Queue is empty. Tasks executed sucessfully.");
            else
                Console.WriteLine("Queue is not empty. Tasks executed unsucessfully.");
        }
    }
}
