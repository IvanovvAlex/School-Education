using System;
using System.Threading;

namespace _1ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread firstThread = new Thread(CountBackwards);
            Thread secondThread = new Thread(CountBackwards);
            firstThread.Start();
            secondThread.Start();
        }

        static Random random = new Random();

        static void CountBackwards()
        {
            int waitTime = random.Next(1, 10) * 1000;
            Console.WriteLine($"Wait time: {waitTime}");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(waitTime);
            }
        }
    }
}
