using System;
using System.Collections.Generic;

namespace SortedSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array_with_duplicates = new int[] { 2, 3, 4, 1, 2, 41, 21, 412, 2, 41, 12,6,1,2,13,1 };

            Console.WriteLine("Length of the Array with duplicates " + array_with_duplicates.Length);

            //Uniquely sorted set. The order of elements is ascending. Internally, it uses a Red-Black Trees
            SortedSet<int> int_sorted_set = new SortedSet<int>(array_with_duplicates);

            Console.WriteLine("The size after removing duplicates is " + int_sorted_set.Count + "\nShowing the contents of SortedSet:");
            foreach (int value in int_sorted_set)
                Console.Write(value + " ");

            Console.WriteLine();
            

            if (int_sorted_set.Remove(13))
                Console.WriteLine("An element is removed");
            else
                Console.WriteLine("Element not found");
           
            if (int_sorted_set.Remove(15))
                Console.WriteLine("An element is removed");
            else
                Console.WriteLine("Element not found");

            //Uses the MAx property
            Console.WriteLine("Max value in the set is " + int_sorted_set.Max);

            SortedSet<int> another_int_sorted_Set = new SortedSet<int>();

            another_int_sorted_Set.Add(1);
            another_int_sorted_Set.Add(2);
            another_int_sorted_Set.Add(7);
            another_int_sorted_Set.Add(5);

            another_int_sorted_Set.UnionWith(int_sorted_set);
            
            Console.WriteLine("After Union:");
            foreach (int value in another_int_sorted_Set)
                Console.Write(value + " ");

            Console.WriteLine();


            Console.WriteLine("After Intersection:");
            foreach (int value in another_int_sorted_Set)
                Console.Write(value + " ");

            Console.WriteLine();


        }
    }
}
