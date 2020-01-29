using System;
using System.Collections;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList customList = new CustomList();

            customList.Add("Timothy");
            customList.Add("Fairway");
            customList.Add("Yeobright");
            customList.Add("Clym");
            customList.Add("Gander");
            customList.Add("Timothy");
            customList.Add("Fairway");
            customList.Add("Yeobright");
            customList.Add("Clym");
            customList.Add("Gander");


            //foreach (var x in customList)
            //    Console.WriteLine(x);

            Console.WriteLine("Count : " + customList.Count + "\nCapacity : " + customList.Capacity);

            for (int i = 0; i < customList.Count; i++)
                Console.WriteLine(customList[i]);

            Console.ReadKey();
        }
    }
}
