using System;
using System.Collections;

namespace SortedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The list is always sorted. Internally, uses a key.value pair to store the elements in keys in sorted and if a new element is added, then it uses Array.binarySearch.
            */
            SortedList sortedList = new SortedList();

            Random random = new Random();

            sortedList.Add(random.Next(),"A");
            sortedList.Add(random.Next(), "B");
            sortedList.Add(random.Next(), "C");
            sortedList.Add(random.Next(), "D");
            sortedList.Add(random.Next(), "E");
            
            for (int i = 0; i < sortedList.Count; i++)
                Console.WriteLine("Key : " + sortedList.GetKey(i) + "\nValue : " + sortedList.GetByIndex(i));

            sortedList.Remove(sortedList.GetKey(1));

            for (int i = 0; i < sortedList.Count; i++)
                Console.WriteLine("Key : " + sortedList.GetKey(i) + "\nValue : " + sortedList[sortedList.GetKey(i)]);


            Console.ReadKey();
        }
    }
}
