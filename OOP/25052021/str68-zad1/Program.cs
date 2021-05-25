using System;
using System.Collections;

namespace str68_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                arrayList.Add(num);                
            }

            arrayList.Sort();
            arrayList.Reverse();

            Console.WriteLine(string.Join(' ', arrayList.ToArray()));
        }
    }
}
