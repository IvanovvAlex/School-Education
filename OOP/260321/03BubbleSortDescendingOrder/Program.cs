using System;
using System.Linq;

namespace _03BubbleSortDescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            var n = arr.Length;
            BubbleSort(arr, n);
            PrintSortedArray(arr, n);
        }

        static void BubbleSort(int[] arr, int arrLength)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < arrLength - 1; i++)
            {
                swapped = false;
                for (j = 0; j < arrLength - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    break;
                }
            }
        }

        static void PrintSortedArray(int[] arr, int size)
        {
            Console.Write("Descending sorted array: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
