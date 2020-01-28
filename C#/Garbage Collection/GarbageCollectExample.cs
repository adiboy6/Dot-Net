using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionPackage
{
    class GarbageCollectExample
    {

        private const int OBJECT_COUNT = 1000;
        private Version v;

        public void makeGarbage()
        {
            for(int i=0;i<OBJECT_COUNT;i++)
            {
                v = new Version();
            }
        }

        public void showMemoryUsage(string mode)
        {
            Console.WriteLine("Memory Usage({0}) : {1} ",mode,GC.GetTotalMemory(true));
        }

        public void collectGarbage()
        {
            GC.Collect();
        }

    }
}
