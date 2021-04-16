using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            float avg, median;
            Console.Write("Enter length of num collection : ");
            n = int.Parse(Console.ReadLine());

            if (n < 3)
            {
                Console.WriteLine("Num must be greater than 2.");
            }

            else
            {
                int[] dataset = new int[n];

                int i = 0;
                for (i = 0; i < n; i++)
                {
                    Console.Write($"[{i}]: ");
                    dataset[i] = int.Parse(Console.ReadLine());
                }

                BubleSorting(dataset, n);

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

                Console.WriteLine("Information:");
                Console.WriteLine("..................................................");
                Console.WriteLine($"Avg: {avg}");
                Console.WriteLine($"Mediana: {median}");

                if (mode[k, 1] != 0)
                {
                    Console.WriteLine($"Moda: {mode[k, 1]}");
                }

                else Console.WriteLine("There is no moda");

            }

            Console.ReadLine();
        }
        static void BubleSorting(int[] arr, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = n - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
        }
    }
}
