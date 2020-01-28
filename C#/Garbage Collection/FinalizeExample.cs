using System;

namespace GarbageCollectionPackage
{
    class FinalizeExample
    {
        private int a;
        private int b;

        public FinalizeExample(int a,int b)
        {
            this.a = a;
            this.b = b;
        }

        public void setA(int a)
        {
            this.a = a;
        }
        public void setB(int b)
        {
            this.b = b;
        }

        public int getA()
        {
            return this.a;
        }

        public int getB()
        {
            return this.b;
        }

        ~FinalizeExample()
        {
            Console.WriteLine("the object is getting destroyed");
            Console.ReadKey();
        }
    }
}
