using System;
using System.IO;

namespace GarbageCollectionPackage
{
    public class UsingBlockUsage
    {
        public void ReadFile(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
