using System;
using System.Collections.Specialized;

namespace HybridDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Optimizes HashTable. If the map is small, it uses a IDictionay and if it is large, then it uses a HashTable 
            HybridDictionary hybridDictionary = new HybridDictionary();

            hybridDictionary.Add(1, "a");
            hybridDictionary.Add(2, "b");
            hybridDictionary.Add(3, "c");
            hybridDictionary.Add(4, "d");
            hybridDictionary.Add(5, "e");

            Console.WriteLine("Displaying the contents of Dictionay");
            foreach (var keys in hybridDictionary.Keys)
                Console.WriteLine("Keys:" + keys + "\nValues:" + hybridDictionary[keys]);

            Console.ReadKey();

        }
    }
}
