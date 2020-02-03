using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace BlockingCollectionExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (BlockingCollection<int> blockingQueue = new BlockingCollection<int>())
            {
                //PRODUCER
                Task producer = Task.Run( ()=>
                {
                    for (int num = 0; num < 5; num++)
                        blockingQueue.Add(num);
                    blockingQueue.CompleteAdding();
                });

                //CONSUMER
                Task consumer = Task.Run(() =>
                {
                    while (blockingQueue.TryTake(out int value))
                        Console.WriteLine("Consumed : " + value);
                });

                //only works if it's aynchronous (uses async keyword)
                await Task.WhenAll(producer, consumer);

            }

        }
    }
}
