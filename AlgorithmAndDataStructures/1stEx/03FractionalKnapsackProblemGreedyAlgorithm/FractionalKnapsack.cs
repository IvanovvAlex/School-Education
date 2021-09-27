using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03FractionalKnapsackProblemGreedyAlgorithm
{
    static class FractionalKnapsack
    {        
        public static void KnapsackGreProc(int[] W, int[] V, int M, int n)
        {
            KnapsackPackage[] packs = new KnapsackPackage[n];
            for (int k = 0; k < n; k++)
                packs[k] = new KnapsackPackage(W[k], V[k]);

            Array.Sort<KnapsackPackage>(packs, new Comparison<KnapsackPackage>(
                 (kPackA, kPackB) => kPackB.Cost.CompareTo(kPackA.Cost)));

            double remain = M;
            double result = 0d;

            int i = 0;
            bool stopProc = false;
                                        //Initialize weight and value for each knapsack package.
                                        //Sort knapsack packages by cost with descending order.
                                        //If select package i.
                                        //If select the number of package i is enough.
                                        //Stop when browsing all packages.
            while (!stopProc)
            {
                if (packs[i].Weight <= remain)
                {
                    remain -= packs[i].Weight;
                    result += packs[i].Value;

                    Console.WriteLine("Pack " + i + " - Weight " + packs[i].Weight + " - Value " + packs[i].Value);
                }

                if (packs[i].Weight > remain)
                {
                    i++;
                }

                if (i == n)
                {
                    stopProc = true;
                }
            }

            Console.WriteLine("Max Value:\t" + result);
        }

        public static void Run()
        {
            
            //Pack and Weight - Value
            
            int[] W = new int[] { 15, 10, 2, 4 };
            //int[] W = new int[] { 12, 2, 1, 1, 4 };

            int[] V = new int[] { 30, 25, 2, 6 };
            //int[] V = new int[] { 4, 2, 1, 2, 10 };

            
            //Max Weight            
            int M = 37;
            //int M = 15;
            int n = V.Length;
            
            KnapsackGreProc(W, V, M, n);
        }
    }
}
