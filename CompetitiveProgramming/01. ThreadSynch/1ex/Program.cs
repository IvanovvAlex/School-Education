using System;
using System.Threading;

namespace _1ex
{
    class Program
    {
        static void Main(string[] args)
        {
            object lockObj = new object();
            int sum = 0;
            var firstThread = new Thread(() =>
            {
                for (int i = 1; i <= 50000; i++)
                {
                    if (i % 2 != 0)
                    {
                        lock (lockObj)
                        {
                            sum += i;
                        }
                    }
                }
            });
            firstThread.Start();

            var secondThread = new Thread(() =>
            {
                for (int i = 50001; i <= 100000; i++)
                {
                    if (i % 2 != 0)
                    {
                        lock (lockObj)
                        {
                            sum += i;
                        }
                    }
                }
            });
            secondThread.Start();
            firstThread.Join();
            secondThread.Join();
            Console.WriteLine(sum);
        }
    }
}
