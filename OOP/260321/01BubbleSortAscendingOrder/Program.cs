using System;
using System.Linq;

namespace _01BubbleSortAscendingOrder
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
            BubbleSort(arr, arrLength);
            PrintSortedArray(arr);
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
                    if (arr[j] > arr[j + 1])
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
        
        static void PrintSortedArray(int[] arr)
        {            
            Console.WriteLine($"Ascending sorted array: {string.Join(", ", arr)}");             
        }
    }
}
