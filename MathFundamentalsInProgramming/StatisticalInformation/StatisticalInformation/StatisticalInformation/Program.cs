using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticalInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            float avg, median;
            Console.Write("Въведете число, което ще определи колко е дълга редицата от числа: ");
            n = int.Parse(Console.ReadLine());

            if (n < 3)
            {
                Console.WriteLine("Числото трябва да е по-голямо от 2.");
            }

            else
            {
                int[] dataset = new int[n];

                int i = 0;
                for (i = 0; i < n; i++)
                {
                    Console.Write("[{0}]: ", i);
                    dataset[i] = int.Parse(Console.ReadLine());
                }

                bubblesort(dataset, n);

                int sum = 0;
                int j = 0;

                while (j < n)
                {
                    sum = sum + dataset[j];
                    j++;
                }

                avg = (float)sum / n;


                if (n % 2 != 0)
                {
                    median = dataset[n / 2];
                }

                else median = (dataset[(n / 2) - 1] + dataset[n / 2]) / (float)2;


                int[,] mode = new int[n, 2];

                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < n; j++) mode[j, i] = 0;
                    {
                        mode[0, 0] = 1;
                    }
                }

                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n - 1; j++)
                    {
                        if (dataset[i] == dataset[j + 1])
                        {
                            ++mode[i, 0]; mode[i, 1] = dataset[i];
                        }
                    }
                }

                int max;
                int k = 0;
                max = mode[0, 0];

                for (j = 0; j < n; j++)
                {
                    if (max < mode[j, 0])
                    {
                        max = mode[j, 0]; k = j;
                    }
                }

                Console.WriteLine("Статистическа информация:");
                Console.WriteLine("..................................................");
                Console.WriteLine("Средна стойност: {0}", avg);
                Console.WriteLine("Медиана: {0}", median);

                if (mode[k, 1] != 0)
                {
                    Console.WriteLine("Мода: {0}", mode[k, 1]);
                }

                else Console.WriteLine("Няма мода");
               
            }

            Console.ReadLine();
        }

        static void bubblesort(int[] dataset, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = n - 1; j > i; j--)
                {
                    if (dataset[j] < dataset[j - 1])
                    {
                        int temp = dataset[j];
                        dataset[j] = dataset[j - 1];
                        dataset[j - 1] = temp;
                    }
                }
            }
        }
    }
}
