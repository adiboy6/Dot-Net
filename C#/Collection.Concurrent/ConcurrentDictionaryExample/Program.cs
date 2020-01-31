using System;
using System.Collections.Concurrent;

namespace ConcurrentDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //the actual number of elements
            int size = 60;

            //the default capacity of dictionary
            int capacity = 100;

            int processorCount = Environment.ProcessorCount;
            
            //dual core processor
            int concurrencyLevel = processorCount * 2;

            //Thread safe Dictionary which implements IDictionary.
            ConcurrentDictionary<int, int> pairs = new ConcurrentDictionary<int, int>(concurrencyLevel, capacity);

            for (int num = 0; num < size; num++)
                pairs[num] = num * num;

            Console.WriteLine("The square of 36 is {0}(should be {1})", pairs[36], 36 * 36);

            Console.ReadKey();
        }
    }
}
