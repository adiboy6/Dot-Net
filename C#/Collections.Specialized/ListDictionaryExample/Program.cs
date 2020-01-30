﻿using System;
using System.Collections;
using System.Collections.Specialized;

namespace ListDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implemented using Linked List
            ListDictionary listDictionary = new ListDictionary();

            //key cannot be null
            //implements IDictionary
            listDictionary.Add(1, "a");
            listDictionary.Add(2, "b");
            listDictionary.Add(3, "c");
            listDictionary.Add(4, "d");
            listDictionary.Add(5, "e");

            //Similar to Entry.Set in Java
            //Order is not guaranteed 
            foreach (DictionaryEntry dict in listDictionary)
                Console.WriteLine(dict.Key + " " + dict.Value);
            Console.ReadKey();
        }
    }
}
