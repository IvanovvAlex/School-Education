using System;

namespace Cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfCoffee = Console.ReadLine();
            double singlePrice = 0d;
            switch (typeOfCoffee)
            {
                case "small":
                    singlePrice = 0.2d;
                    break;
                case "normal":
                    singlePrice = 0.4d;
                    break;
                case "big":
                    singlePrice = 0.6d;
                    break;
            }
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine($"{singlePrice*quantity:F2}lv.");
        }
    }
}
