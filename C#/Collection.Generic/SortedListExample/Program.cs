using System;
using System.Collections.Generic;

namespace SortedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> pairs = new SortedList<int, string>();

            pairs.Add(1, "A");
            pairs.Add(6, "B");
            pairs.Add(3, "C");
            pairs.Add(4, "D");
            pairs.Add(5, "E");

            Console.WriteLine("Show the content");
            foreach (var key in pairs.Keys)
                Console.WriteLine("Key : " + key + "\nValue : " + pairs[key] + "\n");

            Console.WriteLine();

            pairs.Remove(5);
            Console.WriteLine("Show the content after changes");
            foreach (var key in pairs.Keys)
                Console.WriteLine("Key : " + key + "\nValue : " + pairs[key] + "\n");

            Console.WriteLine("Index of key=3 is " + pairs.IndexOfKey(3));

            Console.WriteLine("Index of value=D is " + pairs.IndexOfValue("D"));

            Console.WriteLine();

        }
    }
}
