using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<object, string> studentDetails = new Dictionary<object, string>();

            studentDetails.Add(1, "Joy");
            studentDetails.Add(2, "Asta");
            studentDetails.Add(3, "Yuno");
            studentDetails.Add(4, "Magma");

            try
            {
                studentDetails.Add(null, "some student");
            }
            catch (ArgumentNullException ex)
            {
                Console.Error.WriteLine(ex);
            }


            Console.WriteLine("\nShowing the Student Details");
            foreach(var key in studentDetails.Keys)
            {
                Console.WriteLine("ID:" + key + "\nNAME:" + studentDetails[key] + "\n");
            }

            //Throws an exception : ArgumentException since key already exists
            //studentDetails.Add(1, "Jack");

            Console.WriteLine("\nShowing the Names of Students");
            foreach (var value in studentDetails.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();

            //Check if a key is present or not
            if (studentDetails.ContainsKey(3))
                Console.WriteLine("ID is present");
            else
                Console.WriteLine("ID is not present");
            

            Console.ReadKey();
        }
    }
}
