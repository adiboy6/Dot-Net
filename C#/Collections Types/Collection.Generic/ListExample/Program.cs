using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> int_list = new List<int>();

            int_list.Add(1);
            int_list.Add(4);
            int_list.Add(3);
            int_list.Add(5);
            int_list.Add(2);

            Console.WriteLine("Size of list is {0}", int_list.Count);

            //Parses out the list
            Console.WriteLine("Values of list:");
            foreach (int element in int_list)
                Console.Write(element + " ");

            Console.WriteLine();

            //Computes the average of elements
            Console.WriteLine("Average is " + int_list.Average());
            
            Console.ReadKey();
            
        }
    }
}
