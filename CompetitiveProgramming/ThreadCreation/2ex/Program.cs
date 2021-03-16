using System;
using System.Threading;

namespace _2ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread firstPlayer = new Thread(FirstPlayer);
            Thread secondPlayer = new Thread(SecondPlayer);
            firstPlayer.Start();
            secondPlayer.Start();
        }

        static Random random = new Random();

        static void FirstPlayer()
        {
            int currentPoints = 0;
            int endPoints = 100;
            while (currentPoints <= endPoints)
            {
                currentPoints += random.Next(1, 10);
                Console.WriteLine($"First player points: { currentPoints }");
             System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("First player Finished!");
        }
        static void SecondPlayer()
        {
            int currentPoints = 0;
            int endPoints = 100;
            while (currentPoints <= endPoints)
            {
                currentPoints += random.Next(1, 10);
                Console.WriteLine($"Second player points: { currentPoints }");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("Second player Finished!");
        }

    }
}
