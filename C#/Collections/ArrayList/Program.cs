using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Aditya");
            arrayList.Add(1.123);
            arrayList.Add(123);

            foreach (var val in arrayList)
                Console.Write(val + " ");

            arrayList.Remove(1.123);

            Console.WriteLine("\nAfter removing an element");

            foreach (var val in arrayList)
                Console.Write(val + " ");

            Console.WriteLine("\nInserting an element");

            arrayList.Insert(2, "something");

            foreach (var val in arrayList)
                Console.Write(val + " ");


            Console.ReadKey();
        }
    }
}
