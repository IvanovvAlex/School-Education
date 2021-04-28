using System;
using System.Threading;

namespace _1exBancAcc
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bbaa = new BankAccount(4000, "0");
            Random random = new Random();

            var thread1 = new Thread(() =>
            {
                for (int i = 1; i < 10; i++)
                {
                    bbaa.Deposit(random.Next(1, 100));
                }
            });
            thread1.Start();

            var thread2 = new Thread(() =>
            {
                for (int i = 11; i < 20; i++)
                {
                    bbaa.Withdraw(random.Next(1, 100));
                }
            });
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }
    }
}
