using System;

namespace _05GreetingByName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            // Console.WriteLine("Hello, " + name + "!"); // конкатенация
            Console.WriteLine($"Hello, {name}!"); // интерполация
        }
    }
}
