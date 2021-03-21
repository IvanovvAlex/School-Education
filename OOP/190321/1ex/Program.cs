using System;
using System.Collections.Generic;
using System.Linq;

namespace _1ex
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Vavedi obsht broi resultati: ");
                int n = int.Parse(Console.ReadLine());
                NValidation(n);
                List<int> results = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Vavedi resultat: ");
                    int result = int.Parse(Console.ReadLine());
                    ResultValidation(result);

                    results.Add(result);
                }

                int counter = 1;
                foreach (var result in results.OrderByDescending(x => x))
                {
                    if (counter == 11)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{counter} mqsto- {result} tochki");
                        counter++;
                    }
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }

        private static void NValidation(int n)
        {
            if (n <= 10 || n > 130)
            {
                throw new ArgumentException("Invalid num!");
            }           
        }
        private static void ResultValidation(int result)
        {
            if (result < 0 || result > 100)
            {
                throw new ArgumentException("Invalid result!");
            }
        }
    }
}
