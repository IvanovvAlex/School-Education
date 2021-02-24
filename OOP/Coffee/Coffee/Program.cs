using System;

namespace Coffee
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string typeOfCoffee = Console.ReadLine();
            double singlePriceOfCoffee = Coffee.SinglePriceOfCoffee(typeOfCoffee);
            int quantity = int.Parse(Console.ReadLine());
            double totalPriceOfCoffee = Coffee.TotalPriceOfCoffee(quantity, singlePriceOfCoffee);
            Console.WriteLine($"Total: {totalPriceOfCoffee:f2}lv.");
        }
    }
}
