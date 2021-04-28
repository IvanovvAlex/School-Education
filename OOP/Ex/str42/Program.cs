using System;
using System.Linq;

namespace str42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.Write("Въведете броя на елементите в първи масив: ");
                int n1 = int.Parse(Console.ReadLine());
                int[] a = new int[n1];
                Console.WriteLine("Въведете елементите от първия масив всеки на нов ред: ");
                for (int i = 0; i < n1; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Въведете елементите от втория масив всеки на нов ред: ");

                Console.Write("Въведете броя на елементите във втори масив: ");
                int n2 = int.Parse(Console.ReadLine());
                int[] b = new int[n2];
                for (int i = 0; i < n2; i++)
                {
                    b[i] = int.Parse(Console.ReadLine());
                }
                TrivialMerge(n1, a, n2, b);
            }
            catch (Exception)
            {
                Console.WriteLine("Невалидни входни данни!");
            }
         
        }
        static void TrivialMerge(int n1, int[] a, int n2, int[] b)
        {
            int[] c = new int[n1 + n2];
            for (int i = 0; i < n1; i++)
            {
                c[i] = a[i];
            }
            for (int i = 0; i < n2; i++)
            {
                c[n1 + i] = b[i];
            }
            System.Array.Sort(c);
            Console.Write("Слят масив: ");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write($"{c[i]} ");
            }
            Console.WriteLine();
        }
    }
}
