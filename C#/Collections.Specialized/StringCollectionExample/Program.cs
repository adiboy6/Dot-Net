using System;
using System.Collections;
using System.Collections.Specialized;

namespace StringCollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] { "India", "USA", "Germany", "Colombia" };

            StringCollection stringCollection = new StringCollection();

            stringCollection.AddRange(stringArray);

            foreach (string str in stringCollection)
                Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
