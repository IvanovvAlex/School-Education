using System;
using System.Threading;

namespace TaskTwo
{
    public class Program      
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            object lockObject = new object();

            SmartLock smartLock = new SmartLock();

            Bathroom toilet = new Bathroom(smartLock, "1");
            Bathroom toilet2 = new Bathroom(smartLock, "2");
            Bathroom toilet3 = new Bathroom(smartLock, "3");


            Thread thread1 = new Thread(() =>
            {
                Person person = new Person();
                bool checker = toilet.IsBusy();
                for (int i = 0; i < 2; i++)
                {
                    lock (lockObject)
                    {

                        if (checker == false)
                        {
                            Console.WriteLine("Person 1 enters toilet 1");
                            person.GoToToilet(toilet);
                            Thread.Sleep(random.Next(1, 10) * 1000);
                            person.LeaveToilet(toilet);
                            Console.WriteLine("Person 1 left toilet 1.");
                            i = 2;
                        }
                        else
                        {
                            Console.WriteLine("Person one waits between 1 and 10 seconds for toilet.");
                            Thread.Sleep(random.Next(1, 3) * 1000);
                            checker = toilet.IsBusy();
                            if (checker == true)
                            {
                                Console.WriteLine("The person leaves unsatisfied.");
                            }
                        }
                    }
                    
                }
            });

            Thread thread2 = new Thread(() =>
            {
                Person person = new Person();
                bool checker = toilet.IsBusy();

                lock (lockObject)
                {
                    if (checker == false)
                    {
                        Console.WriteLine("Person 2 enters toilet 1");
                        person.GoToToilet(toilet);
                        Thread.Sleep(random.Next(1, 10) * 1000);
                        person.LeaveToilet(toilet);
                        Console.WriteLine("Person 2 left toilet 1.");
                    }
                    else
                    {
                        Console.WriteLine("Person 2 leaves unsatisfied.");
                    }
                }
            });

            Thread thread3 = new Thread(() =>
            {
                Person person = new Person();
                bool checker = toilet2.IsBusy();

                lock (lockObject)
                {
                    if (checker == false)
                    {
                        Console.WriteLine("Person 3 enters toilet 2");
                        person.GoToToilet(toilet2);
                        Thread.Sleep(random.Next(1, 10) * 1000);
                        person.LeaveToilet(toilet2);
                        Console.WriteLine("Person 3 left toilet 2.");
                    }
                    else
                    {
                        Console.WriteLine("Person 3 leaves unsatisfied.");
                    }
                }
            });

            Thread thread4 = new Thread(() =>
            {
                Person person = new Person();
                bool checker = toilet3.IsBusy();

                lock (lockObject)
                {
                    if (checker == false)
                    {
                        Console.WriteLine("Person 4 enters toilet 3");
                        person.GoToToilet(toilet3);
                        Thread.Sleep(random.Next(1, 10) * 1000);
                        person.LeaveToilet(toilet3);
                        Console.WriteLine("Person 4 left toilet 3.");
                    }
                    else
                    {
                        Console.WriteLine("Person 4 leaves unsatisfied.");
                    }
                }
            });

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
        }
    }
}
