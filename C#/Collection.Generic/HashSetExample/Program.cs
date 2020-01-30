using System;
using System.Collections.Generic;

namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 2, 3, 4, 6, 7, 8 };

            Console.WriteLine("Size of array " + array.Length);
            
            //duplicates are removed and added in the set
            HashSet<int> hashSet = new HashSet<int>(array);

            Console.WriteLine("Unique elements of array in a set");
            foreach (int value in hashSet)
                Console.Write(value + " ");

            Console.WriteLine();

            Console.WriteLine("Hash Code is " + hashSet.GetHashCode());

            Console.ReadKey();
        }
    }
}
