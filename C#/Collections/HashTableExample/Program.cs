using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();

            hashTable.Add(101, "Janice");
            hashTable.Add(102, "Sienna");
            hashTable.Add(104, "Chris");
            hashTable.Add(103, "Adam");

            foreach (var key in hashTable.Keys)
                Console.WriteLine("Key : {0}\nValue : {1}", key, hashTable[key]);

            Console.ReadKey();

        }
    }
}
