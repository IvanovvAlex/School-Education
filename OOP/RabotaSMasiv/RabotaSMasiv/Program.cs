using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RabotaSMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = new int[130];
            Console.WriteLine("Enter the number of students: ");
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            StreamWriter w = new StreamWriter("file.txt", false, Encoding.GetEncoding("Unicode"));
            for (int i = 0; i < n; i++)
            {
                w.Write(r.Next() % 101 + " ");
            }
            w.Close();
            StreamReader p = new StreamReader("file.txt", Encoding.GetEncoding("Unicode"));
            string line = p.ReadLine();
            p.Close();
            int pos = 0, next;
            next = line.IndexOf(" ", pos);
            for (int i = 0; i<n;i++)
            {
                points[i] = int.Parse(line.Substring(pos, next - pos));
                pos = next + 1; next = line.IndexOf(" ", pos);
            }

            for (int k = 0; k < 10; k++)
            {
                for (int j = k+1; j<n; j++)
                {
                    if (points[j]>points[k])
                    {
                        int tmp = points[j];
                        points[j] = points[k];
                        points[k] = tmp;
                    }
                }
            }

            Console.WriteLine("The best 10 results are: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", points [0], points[1],points[2],points[3],points[4],points[5],points[6], points[7], points[8], points[9]);

        }
    }
}
