using System;

namespace DelegateExample
{
    class Program
    {
        delegate double doubleArgumentDelegateMethod(double arg);

        delegate void arrayParameterDelegateMethod(double[] array);

        delegate void doubleArgumentVoidDelegateMethod(double arg);

        static double Square(double arg)
        {
            return arg * arg;
        }

        static double MultiplyWith2(double arg)
        {
            return 2 * arg;
        }

        static void showSquare(double arg)
        {
            Console.WriteLine("Square " + Square(arg)); ;
        }

        static void showMultiplyWith2(double arg)
        {
            Console.WriteLine("Multiply with 2 " + MultiplyWith2(arg));
        }


        static double[] Map(double[] arr, doubleArgumentDelegateMethod method)
        {
            double[] ans = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                ans[i] = method(arr[i]);
            return ans;
        }

        static void Main(string[] args)
        {
            //Anonymous delegate or inline delegate
            arrayParameterDelegateMethod show = delegate (double[] array)
            {
                foreach (int val in array)
                    Console.Write(val + " ");
                Console.WriteLine("\n");
            };

            double[] a = { 1, 2, 3, 4 };

            Console.WriteLine("Before any operation on the array:");

            //Usage of Anonnymous delegate
            show(a);

            //Passing Square function to the function Map
            double[] ans = Map(a, Square);

            Action<double[]> display = delegate (double[] array)
            {
                foreach (int val in array)
                    Console.Write(val + " ");
                Console.WriteLine("\n");
            };

            Console.WriteLine("After squaring the array:");
            
            display(ans);

            //delegate object is created
            doubleArgumentDelegateMethod delegateMethod = new doubleArgumentDelegateMethod(MultiplyWith2);
            
            //Passing delegate object to the function Map
            double[] ans1 = Map(a, delegateMethod);

            Console.WriteLine("After multiplying 2 to the array:");
            show(ans);

            Func<double> PI = delegate
            {
                return 22.0 / 7.0;
            };

            Console.WriteLine("PI = " + PI());

            //Multicast delegate
            //Declaring three delegates
            doubleArgumentVoidDelegateMethod mult, square, combine;

            mult = showMultiplyWith2;
            square = showSquare;
            combine = square + mult;

            combine(6);

            Console.ReadKey();
        }
    }
}
