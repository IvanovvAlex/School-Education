using System;

namespace _08PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal dogs = decimal.Parse(Console.ReadLine());
            decimal otherAnimals = decimal.Parse(Console.ReadLine());

            dogs *= 2.5m; // dogs = dogs * 2.5
            otherAnimals *= 4m;

            Console.WriteLine($"{dogs+otherAnimals} lv.");
        }
    }
}
