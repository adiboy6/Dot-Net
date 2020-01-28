using System;
using System.IO;

namespace GarbageCollectionPackage
{
    public class DisposableExample : IDisposable 
    {
        private bool IsDisposed = false;

        private StreamReader sr;

        public DisposableExample(string path)
        {
            Console.WriteLine("Inside DisposableExample class constructor");

            sr = File.OpenText(path);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!IsDisposed)
            {
                //managed resources
                if (disposing)
                {
                    Console.WriteLine("Disposing off managed code");
                    
                    if(this == null)
                        this.Dispose();
                }
            }

            Console.WriteLine("Disposing off unmanaged code");
            if (sr != null)
                sr.Close();

            IsDisposed = true;

            Console.ReadKey();
        }

        public void ReadFile()
        {
            Console.WriteLine("Performing Read operations on the file");

            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }

        ~DisposableExample()
        {
            if(sr!=null)
                Console.WriteLine("Inside DisposableExample finalizer");
            Console.ReadKey();
            Dispose(false);
        }

    }
}
