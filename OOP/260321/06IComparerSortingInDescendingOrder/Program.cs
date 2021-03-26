using System;
using System.Collections;
using System.Collections.Generic;

namespace _06IComparerSortingInDescendingOrder
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
            IComparer comp = new OtherComparer();
            Array.Sort(arr, comp);
            PrintArray(arr);
        }

        class OtherComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                int xcopy = (int)x, ycopy = (int)y;
                int si = 0, s2 = 0;
                while (xcopy != 0)
                {
                    si += xcopy % 10;
                    xcopy /= 10;
                }
                while (ycopy != 0)
                {
                    s2 += ycopy % 10;
                    ycopy /= 10;
                }
                if (si > s2)
                {
                    return -1;
                }
                else if (si < s2)
                {
                    return 1;
                }
                else if ((int)x > (int)y)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }
        static void PrintArray(int[] arr)
        {
            Console.WriteLine($"Sorted array in descending order: {string.Join(", ", arr)}");
        }
    }
}
