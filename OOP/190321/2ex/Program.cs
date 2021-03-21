using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Text;

namespace _2ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(11, 130);

           
            for (int i = 0; i < n; i++)
            {
                int result = rnd.Next(0, 100);

                StreamWriter output = new StreamWriter("file.txt", false, Encoding.GetEncoding("Unicode"));
                output.Write(result + " ");
                
            }
            
            List<int> results = new List<int>();
            for (int i = 0; i < n; i++)
            {
                StreamReader inputFile = new StreamReader("file.txt", Encoding.GetEncoding("Unicode"));

                string input = inputFile.ReadLine();
                    inputFile.Close();
                    results = input
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();
                   
                
            }
            int counter = 1;
            foreach (var result in results.OrderByDescending(x => x))
            {
                if (counter == 11)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{counter} mqsto- {result} tochki");
                    counter++;
                }
            }
            //using (FileStream fs = new FileStream(cDirs + @"\Results.txt", FileMode.Truncate))
            //{
            //}
        }
    }
}
