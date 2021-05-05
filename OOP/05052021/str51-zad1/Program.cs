using System;
using System.Linq;

namespace str51_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string enteredString = Console.ReadLine();
            var reversedString = enteredString.Reverse().ToArray();
            bool isMatching = true;
            for (int i = 0; i < enteredString.Length; i++)
            {
                if (enteredString[i] != reversedString[i])
                {
                    isMatching = false;
                }
            }
            if (isMatching)
            {
                Console.WriteLine($"The string [{enteredString}] is palindrom");
            }
            else
            {
                Console.WriteLine($"The string [{enteredString}] isn't palindrom");
            }
        }
    }
}
