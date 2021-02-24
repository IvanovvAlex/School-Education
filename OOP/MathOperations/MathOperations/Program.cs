using System;
using System.Linq;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                .Split()
                .ToArray();

            int firstNum = int.Parse(line[0]);
            int secondNum = int.Parse(line[2]);
            char sign = char.Parse(line[1]);

            switch (sign)
            {
                case '*':
                   int result = Arithmetics.Multiply(firstNum, secondNum);
                    Console.WriteLine($"Result: {result}");
                    break;
                case '+':
                    result =  Arithmetics.Add(firstNum, secondNum);
                    Console.WriteLine($"Result: {result}");
                    break;
            }
            
        }
    }
}
