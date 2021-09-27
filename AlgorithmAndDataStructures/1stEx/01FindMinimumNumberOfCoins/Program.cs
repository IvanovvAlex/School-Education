using System;

namespace _01FindMinimumNumberOfCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = { 25, 10, 5, 1 };
            int amount, count, i;
            Console.Write("Enter the amount you want to change : ");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==========================");
            for (i = 0; i < coins.Length; i++)
            {
                count = amount / coins[i];
                if (count != 0)
                    Console.WriteLine($"Count of {coins[i]} cent(s) :{count}");
                amount %= coins[i];
            }

            Console.ReadLine();
        }
    }
}
