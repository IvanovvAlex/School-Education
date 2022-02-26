using System;

namespace MergeSort
{
    class Program
    {
        public class Merge
        {

            public void merge(int[] arr, int l, int m, int r)
            {
                int n1 = m - l + 1;
                int n2 = r - m;

                int[] L = new int[n1];
                int[] R = new int[n2];
                int i, j;

                for (i = 0; i < n1; ++i)
                    L[i] = arr[l + i];
                for (j = 0; j < n2; ++j)
                    R[j] = arr[m + 1 + j];

                i = 0;
                j = 0;

                int k = l;
                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j++;
                    }
                    k++;
                }

                while (i < n1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }

                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }

            public void sort(int[] arr, int l, int r)
            {
                if (l < r)
                {
                    int m = l + (r - l) / 2;

                    sort(arr, l, m);
                    sort(arr, m + 1, r);

                    merge(arr, l, m, r);
                }
            }

        }
        public static void Main(String[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Given Array");
            Console.WriteLine(string.Join(' ', arr));
            Merge ob = new Merge();
            ob.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            Console.WriteLine(string.Join(' ', arr));
        }
    }
}
