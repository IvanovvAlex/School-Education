using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26062021
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Operations
    {
        public static int Pow(int m, int n)
        {
            return (int)Math.Pow(m, n);
        }
        public static int Factoriel(int m)
        {
            int fact = 1;
            for (int i = 1; i <= m; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public static BigInteger BinomenKoef(BigInteger m, BigInteger n)
        {
            return CombWithout(m, n - 1) + CombWithout(m - 1, n - 1);
        }
        public static BigInteger Variacii(BigInteger m, BigInteger n)
        {
            BigInteger result = n;

            for (int i = 0; i < m - 1; i++)
            {
                result *= --n;
            }
            return result;
        }
        public static BigInteger CombWithout(BigInteger m, BigInteger n)
        {
            BigInteger fact = 1;
            BigInteger result = n;
            
            for (int i = 1; i <= m; i++)
            {
                fact *= i;
            }
            for (int i = 0; i < m - 1; i++)
            {
                result *= --n;
            }
            return result / fact;
        }
        public static BigInteger CombWith(BigInteger m, BigInteger n)
        {
            return CombWithout(n - 1, n + m - 1);
        }
    }
}
