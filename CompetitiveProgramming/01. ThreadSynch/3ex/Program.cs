using System;
using System.Threading;

namespace _3ex
{
    class Program
    {
        static void Main(string[] args)
        {
            object lockObj = new object();
            int counter = 0;
            var firstThread = new Thread(() =>
            {
                for (int i = 1; i <= 500000; i++)
                {
                    bool isPrime = true;
                    for (int div = 2; div <= Math.Sqrt(i); div++)
                    {
                        if (i % div == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        lock (lockObj)
                        {
                            counter++;
                        }
                    }
                }
            });
            firstThread.Start();

            var secondThread = new Thread(() =>
            {
                for (int i = 500001; i <= 1000000; i++)
                {
                    bool isPrime = true;
                    for (int div = 2; div <= Math.Sqrt(i); div++)
                    {
                        if (i % div == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        lock (lockObj)
                        {
                            counter++;
                        }
                    }
                }
            });
            secondThread.Start();
            firstThread.Join();
            secondThread.Join();
            Console.WriteLine(counter);
        }
    }
}
