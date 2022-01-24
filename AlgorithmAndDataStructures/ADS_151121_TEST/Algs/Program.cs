using System;
using System.Collections.Generic;

namespace Algs
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
       
    }
    public static class CombinationsWithRep
    {
        private static int numberofCombos;
        private static int n;
        private static int k;
        private static int[] storageArr;

        public static void Main()
        {
            n = 4;
            k = 2;
            storageArr = new int[k];

            GenCombinationsWithRep();
        }

        private static void GenCombinationsWithRep(int index = 0, int element = 0)
        {
            if (index >= storageArr.Length)
            {
                PrintCombo();
                return;
            }

            for (int i = element; i < n; i++)
            {
                storageArr[index] = i;
                GenCombinationsWithRep(index + 1, i);
            }
        }

        private static void PrintCombo()
        {
            Console.WriteLine(
                "{0,3}: [{1}]",
                ++numberofCombos,
                string.Join(", ", storageArr));
        }
    }
    public static class VariationsWithRep
    {
        private static int numberOfCombos;
        private static int n;
        private static int k;
        private static int[] workArr;

        public static void Main()
        {
            n = 3;
            k = 2;
            workArr = new int[k];

            GenerateVariationsWithRep();
        }

        private static void GenerateVariationsWithRep(int index = 0)
        {
            if (index >= k)
            {
                PrintCombo();
                return;
            }

            for (int i = 0; i < n; i++)
            {
                workArr[index] = i;
                GenerateVariationsWithRep(index + 1);
            }
        }

        private static void PrintCombo()
        {
            Console.WriteLine($"{++numberOfCombos}: [{string.Join(", ", workArr)}]");
        }
    }
    public static class PermutationsWithRep
    {
        private static int numberOfCombos;

        public static void Main()
        {
            var collection = new[] { 6, 1, 1, 1, 1, 1, 1, 1, 1 };
            PermuteRep(collection);
        }

        private static void PermuteRep<T>(T[] workArray, int? end = null, int start = 0)
            where T : IComparable<T>
        {
            if (end == null)
            {
                end = workArray.Length - 1;
            }

            PrintPerm(workArray);

            for (int left = end.Value - 1; left >= start; left--)
            {
                for (int right = left + 1; right <= end; right++)
                    if (workArray[left].CompareTo(workArray[right]) != 0)
                    {
                        Swap(ref workArray[left], ref workArray[right]);
                        PermuteRep(workArray, end, left + 1);
                    }

                var firstElement = workArray[left];

                for (int i = left; i <= end.Value - 1; i++)
                {
                    workArray[i] = workArray[i + 1];
                }

                workArray[end.Value] = firstElement;
            }
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        private static void PrintPerm<T>(T[] arr)
        {
            Console.WriteLine($"{++numberOfCombos}: [{string.Join(", ", arr)}]");
        }
    }
}
