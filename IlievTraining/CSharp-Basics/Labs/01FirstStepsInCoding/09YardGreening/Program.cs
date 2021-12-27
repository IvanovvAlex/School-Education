using System;

namespace _09YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double price = meters * 7.61;
            double result = price * 0.82;

            Console.WriteLine($"The final price is: {result} lv.The discount is: {price-result:F2} lv.");
        }
    }
}
