using System;
using System.Threading;

namespace _1ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(run);
            thread.Start();
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine($"Letter thread: {(char)('A'+i)}");
            }
        }

         static void run()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Num thread: {i}");
            }
        }
    }
}
