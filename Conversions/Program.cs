using System;

namespace Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion
            int num = 123456789;
            long bigNum = num;

            // Explicit conversion
            double x = 1234.7;
            int a;
            // Cast double to int
            a = (int)x;

            Console.WriteLine(num);
            Console.WriteLine(bigNum);
            Console.WriteLine(x);
            Console.WriteLine(a);
        }
    }
}