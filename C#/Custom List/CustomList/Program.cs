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

            String[] str = new String[4];

            str[0] = "Tim";
            str[1] = "Max";
            str[2] = "Adi";
            str[3] = "Ash";

            Console.WriteLine("Before Copy:");

            foreach (string s in str)
                Console.WriteLine(s);

            customList.CopyTo(str);

            //foreach (var x in customList)
            //    Console.WriteLine(x);

            Console.WriteLine("Count : " + customList.Count + "\nCapacity : " + customList.Capacity);

            for (int i = 0; i < customList.Count; i++)
                Console.WriteLine(customList[i]);

            foreach(string s in str)
                Console.WriteLine(s);

            Console.WriteLine("Index of Fairway is {0}", customList.IndexOf("Fairwayl"));

            Console.WriteLine("\nInserting Cantle at index 2.\n");

            customList.Insert(2, "Cantle");
            customList.Insert(5, "Egdon");


            for (int i = 0; i < customList.Count; i++)
                Console.WriteLine(customList[i]);

            //Console.WriteLine("\nRemoving Cantle.\n");

            //customList.Remove("Cantle");
            //customList.Remove("Egdon");
            
            //for (int i = 0; i < customList.Count; i++)
            //    Console.WriteLine(customList[i]);

            Console.WriteLine("\nRemoving elements from 1 to 3.\n");

            customList.RemoveRange(1, 3);

            for (int i = 0; i < customList.Count; i++)
                Console.WriteLine(customList[i]);

            Console.ReadKey();
        }
    }
}
