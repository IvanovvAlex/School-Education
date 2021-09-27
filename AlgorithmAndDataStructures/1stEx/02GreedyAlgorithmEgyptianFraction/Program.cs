using System;

namespace _02GreedyAlgorithmEgyptianFraction
{
    class Program
    {
       
       
        public static void Main()
        {
            int nr = int.Parse(Console.ReadLine());
            int dr = int.Parse(Console.ReadLine());
            Console.Write("Egyptian Fraction Representation of " +
                                         nr + "/" + dr + " is\n ");
            Controller.PrintEgyptian(nr, dr);
        }
    }
}

