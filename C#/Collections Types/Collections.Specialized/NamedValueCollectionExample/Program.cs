using System;
using System.Collections;
using System.Collections.Specialized;

namespace NamedValueCollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //String keys and String values that can be accessed with the key or index
            NameValueCollection nameValueCollection = new NameValueCollection();

            //key cannot be null
            nameValueCollection.Add("A", "India");
            nameValueCollection.Add("B", "Japan");
            nameValueCollection.Add("C", "USA");
            nameValueCollection.Add("D", "Mexico");
            nameValueCollection.Add("E", "Congo");

            //Gettign tje value at a key
            Console.WriteLine("The value at key 'A' is " + nameValueCollection["A"]);

            //Getting the value at an index
            Console.WriteLine("The value at index 1 is " + nameValueCollection[1]);

            for (int i=0; i<nameValueCollection.Count; i++ )
                Console.WriteLine(nameValueCollection.GetKey(i) + " " + nameValueCollection.Get(i));

            Console.ReadKey();
        }
    }
}
