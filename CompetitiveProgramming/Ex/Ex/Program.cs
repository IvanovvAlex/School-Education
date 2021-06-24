using System;
using System.Threading;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstThread.Start();
            SecondThread.Start();
        }
    }
    class FirstThread
    {
        public static void Start()
        {
            Thread thread = new Thread(new ThreadStart(Code));
            thread.Start();
            thread.Join();
        }
        public static void Code() 
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                Console.WriteLine(rnd.Next(0, 100));
            }
        }
        

    }
    class SecondThread
    {
        public static void Start()
        {
            Thread thread = new Thread(new ThreadStart(Code));
            thread.Start();
        }
        public static void Code()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                Console.WriteLine(rnd.Next(100, 200));
            }
        }
    }
}
