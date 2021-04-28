using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _1ex
{
    public class CountingThread
    {
        public void CountDown(int length)
        {
            for (int i = length - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("Go!");
        }
    }
}
