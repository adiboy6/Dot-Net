using System;
using System.IO;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConcurrentBagExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //a thread safe, unordered collection which even allows duplicate
            ConcurrentBag<string> fileList = new ConcurrentBag<string>();

            string[] dir_name = { ".", ".." };
            
            List<Task> taskList = new List<Task>();
            
            //Tasks for adding the value
            foreach(string dir in dir_name)
            {
                taskList.Add(Task.Run( () =>
                    {
                        foreach (string path in Directory.GetFiles(dir))
                            fileList.Add(path);
                    }
                    ));
            }
            Task.WaitAll(taskList.ToArray());

            List<Task> dup_taskList = new List<Task>();

            int fileCount = 0;

            //pops/takes out each element in a task
            while(!(fileList.IsEmpty))
            {
                dup_taskList.Add( Task.Run(() =>
                {
                    string value;
                    if(fileList.TryTake(out value))
                    {
                        Console.WriteLine(value);
                        fileCount++;
                    }
                }

                ));
            }

            Task.WaitAll(dup_taskList.ToArray());

            Console.WriteLine("Total number of files are {0}", fileCount);

            string checkValue;
            //attempts to return a value instaad of removing
            if (fileList.TryPeek(out checkValue))
                Console.WriteLine("Theres still some file {0} present", checkValue);


            Console.ReadKey();
        }
    }
}
