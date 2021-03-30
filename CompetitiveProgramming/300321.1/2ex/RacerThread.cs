using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _1ex
{
    public class RacerThread
    {
        public void Race(int distance)
        {
            for (int i = 1; i <= distance; i++)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} : {i}");
                Thread.Sleep(100);
            }
        }
    }
}
