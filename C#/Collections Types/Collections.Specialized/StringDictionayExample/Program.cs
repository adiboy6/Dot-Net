using System;
using System.Collections;
using System.Collections.Specialized;

namespace StringDictionayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //implements Hash Table with key/value strongly typed
            StringDictionary stringDictionary = new StringDictionary();

            stringDictionary.Add("A", "India");
            stringDictionary.Add("B", "Japan");
            stringDictionary.Add("C", "USA");
            stringDictionary.Add("D", "Mexico");
            stringDictionary.Add("E", "Congo");

            //Similar to Entry.Set in Java
            //Order is not guaranteed 
            foreach (DictionaryEntry dict in stringDictionary)
                Console.WriteLine(dict.Key + " " + dict.Value);

            Console.ReadKey();

        }
    }
}
