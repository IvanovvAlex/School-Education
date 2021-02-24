using System;
using System.Threading;

namespace _2ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(run);
            thread.Start();
            int counter = 0;
            for (int i = 0; i < 100; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine($"{i} is prime");
                    counter++;
                }                             
            }
            Console.WriteLine(counter);
            
        }

        static void run()
        {
            for (int i = 7; i < 98; i+=10)
            {
                Console.WriteLine($"Num thread: {i}");
            }
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
