using System;

namespace FibDyn
{
    class Program
    {
        public static long Fib(long n)
        {
            if (n <= 1)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
            Console.Write(Fib(10));
        }
    }
}
