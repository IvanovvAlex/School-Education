using System;

namespace _04SelectionSortDescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }
            Sorting(arr);
            PrintArray(arr);
        }
        static void Sorting(int[] arr)
        {
            int arrLength = arr.Length;
            for (int i = 0; i < arrLength - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < arrLength; j++)
                {
                    if (arr[j] > arr[min_idx])
                    {
                        min_idx = j;
                    }
                }

                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }


        static void PrintArray(int[] arr)
        {
            Console.WriteLine($"Sorted array in descending order: {string.Join(", ", arr)}");
        }
    }
}
