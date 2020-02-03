using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ReadOnlyCollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            list.Add("E");

            //A collection is passed to ReadOnly. This collection(ReadOnlyCollection) value cannot be modified. 
            ReadOnlyCollection<string> readonlyList = new ReadOnlyCollection<string>(list);

            foreach(string value in readonlyList)
            {
                Console.WriteLine(value);
            }

            //Not possible since the value cannot be changed
            //readonlyList[0] = "adding somthing";
        }
    }
}
