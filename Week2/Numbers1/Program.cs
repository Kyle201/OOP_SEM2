using System;

namespace Numbers1
{
    class Program
    {
        static int FibonacciSeries(int n)
        {
            int a = 0, b = 1, result = 0;

            if (n == 0) return 0;
            if (n == 1) return 1;


            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return result;

        }
        static void Main()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(FibonacciSeries(i));
            }
            Console.ReadLine();
        }
    }
}
