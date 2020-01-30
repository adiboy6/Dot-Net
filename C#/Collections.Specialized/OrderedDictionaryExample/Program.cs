using System;
using System.Collections;
using System.Collections.Specialized;

namespace OrderedDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stored DictionaryEntry object
            OrderedDictionary orderedDictionary = new OrderedDictionary();
            
            orderedDictionary.Add(1, "a");
            orderedDictionary.Add(2, "b");
            orderedDictionary.Add(6, "c");
            orderedDictionary.Add(4, "d");
            orderedDictionary.Add(5, "e");

            Console.WriteLine("Count " + orderedDictionary.Count);

            foreach (DictionaryEntry dict in orderedDictionary)
                Console.WriteLine(dict.Key + " " + dict.Value);

            Console.ReadKey();

        }
    }
}
