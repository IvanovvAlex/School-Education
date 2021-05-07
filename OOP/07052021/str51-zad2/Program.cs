using System;
using System.Collections.Generic;

namespace str51_zad2
{
    class Program
    {
        public static void Main()
        {
            string expression = Console.ReadLine();
            bool stackResult = checkValidity(expression);

            if (stackResult)
                Console.WriteLine("Скобите са наред");
            else
                Console.WriteLine("\nОпс, някъде имаш грешка!");
        }

        private static bool checkValidity(string expression)
        {
            Stack<char> openStack = new Stack<char>();
            foreach (char c in expression)
            {
                switch (c)
                {
                    case '{':
                    case '(':
                    case '[':
                        openStack.Push(c);
                        break;
                    case '}':
                        if (openStack.Count == 0 || openStack.Peek() != '{')
                        {
                            return false;
                        }
                        openStack.Pop();
                        break;
                    case ')':
                        if (openStack.Count == 0 || openStack.Peek() != '(')
                        {
                            return false;
                        }
                        openStack.Pop();
                        break;
                    case ']':
                        if (openStack.Count == 0 || openStack.Peek() != '[')
                        {
                            return false;
                        }
                        openStack.Pop();
                        break;
                    default:
                        break;
                }
            }
            return openStack.Count == 0;
        }
    }
}