using System;

namespace str43
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
                Merge(n1, a, n2, b);
            }
            catch (Exception)
            {
                Console.WriteLine("Невалидни входни данни!");
            }
        }

        static void Merge(int n1, int[] a, int n2, int[] b)
        {
            int m1 = 0;
            int m2 = 0;
            int n = -1;

            int[] c = new int[n1 + n2];
            while (m1 < n1 && m2 < n2)
            {
                if (a[m1] <= b[m2])
                {
                    c[++n] = a[m1++];
                }
                else
                {
                    c[++n] = b[m2++];
                }
            }
            if (m1 == n1)
            {
                for (int i = m2; i < n2; i++)
                {
                    c[++n] = b[i];
                }                
            }
            else
            {
                for (int i = m1; i < n1; i++)
                {
                    c[++n] = a[i];
                }
            }
            Console.Write("Слят масив: ");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.WriteLine();            
        }
    }
}
