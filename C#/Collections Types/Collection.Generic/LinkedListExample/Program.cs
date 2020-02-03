using System;
using System.Collections.Generic;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //works as a double linked list
            LinkedList<int> int_list = new LinkedList<int>();

            int_list.AddFirst(1);
            int_list.AddFirst(2);
            int_list.AddFirst(3);
            int_list.AddFirst(4);
            int_list.AddFirst(5);

            //works as Add method as in List or ArrayList
            int_list.AddLast(0);
            int_list.AddLast(-1);

            Console.WriteLine("Size of  the list " + int_list.Count);

            Console.WriteLine("Showing the List:");
            foreach (var value in int_list)
                Console.Write(value + " ");
            Console.WriteLine();
            
            //Removes the First node
            int_list.RemoveFirst();

            //Removes the Last node
            int_list.RemoveLast();

            Console.WriteLine("Showing the List after removing first and last node:");
            foreach (var value in int_list)
                Console.Write(value + " ");
            Console.WriteLine();

            LinkedListNode<int> first_node = int_list.First;

            Console.WriteLine("First value of the list is " + first_node.Value);

            Console.WriteLine("Second value of the list is " + first_node.Next.Value);

            Console.ReadKey();
        }
    }
}
