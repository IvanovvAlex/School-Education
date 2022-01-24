using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02GreedyAlgorithmEgyptianFraction
{
    static class Controller
    {
        public static void PrintEgyptian(int nr, int dr)
        {
            // If either numerator or
            // denominator is 0
            if (dr == 0 || nr == 0)
                return;

            // If numerator divides denominator,
            // then simple division  makes
            // the fraction in 1/n form
            if (dr % nr == 0)
            {
                Console.Write("1/" + dr / nr);
                return;
            }

            // If denominator divides numerator,
            // then the given number is not fraction
            if (nr % dr == 0)
            {
                Console.Write(nr / dr);
                return;
            }

            // If numerator is more than denominator
            if (nr > dr)
            {
                Console.Write(nr / dr + " + ");
                PrintEgyptian(nr % dr, dr);
                return;
            }

            // We reach here dr > nr and dr%nr
            // is non-zero. Find ceiling of
            // dr/nr and print it as first
            // fraction
            int n = dr / nr + 1;
            Console.Write("1/" + n + " + ");

            // Recur for remaining part
            PrintEgyptian(nr * n - dr, dr * n);
        }

    }
}
