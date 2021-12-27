using System;

namespace _06SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (10 < speed && speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (50 < speed && speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (150 < speed && speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (1000 < speed)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
