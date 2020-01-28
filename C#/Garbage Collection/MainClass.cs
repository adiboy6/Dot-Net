using System;

namespace GarbageCollectionPackage
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Aditya_Sabbella\\Desktop\\Java\\Experiments.java";

            //'using' usage
            UsingBlockUsage usingBlock = new UsingBlockUsage();
            usingBlock.ReadFile(path);

            Console.WriteLine();

            //Disposable usage
            DisposableExample disposableExample = new DisposableExample(path);

            disposableExample.ReadFile();
            disposableExample.Dispose();

            Console.WriteLine();

            //Finalize(destructor) usage
            FinalizeExample finalizeExample = new FinalizeExample(1, 2);

            Console.WriteLine(finalizeExample.getA() + " " + finalizeExample.getB());

            //GC.Collect usage
            GarbageCollectExample garbageCollectExample = new GarbageCollectExample();

            garbageCollectExample.makeGarbage();
            garbageCollectExample.showMemoryUsage("before");
            garbageCollectExample.collectGarbage();
            garbageCollectExample.showMemoryUsage("after");

            Console.ReadKey();

        }
    }
}
