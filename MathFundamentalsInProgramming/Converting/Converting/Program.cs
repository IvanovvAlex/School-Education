using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] signs = command.Split();


                switch (signs[0])
                {
                    case "BO":
                        {
                            Console.Write("Enter binary number: ");
                            string bin = Console.ReadLine();
                            Console.WriteLine($"{bin} to octal is {Convert.ToString(Convert.ToInt32(bin, 2), 8)} ");
                            break;
                        }

                    case "BD":
                        {
                            Console.Write("Enter binary number: ");
                            string bin = Console.ReadLine();
                            Console.WriteLine($"{bin} to decimal is {Convert.ToString(Convert.ToInt32(bin, 2), 10)} ");
                            break;
                        }

                    case "BH":
                        {
                            Console.Write("Enter binary number: ");
                            string bin = Console.ReadLine();
                            Console.WriteLine($"{bin} to hexadecimal is {Convert.ToInt32(bin, 2).ToString("X")}");
                            break;
                        }

                    case "OB":
                        {
                            Console.Write("Enter octal number: ");
                            string oct = Console.ReadLine();
                            Console.WriteLine($"{oct} to binary is {Convert.ToString(Convert.ToInt32(oct, 8), 2)} ");
                            break;
                        }

                    case "OD":
                        {
                            Console.Write("Enter octal number: ");
                            string oct = Console.ReadLine();
                            Console.WriteLine($"{oct} to decimal is {Convert.ToString(Convert.ToInt32(oct, 8), 10)} ");
                            break;
                        }

                    case "OH":
                        {
                            Console.Write("Enter octal number: ");
                            string oct = Console.ReadLine();
                            Console.WriteLine($"{oct} to hexadecimal is {Convert.ToInt32(oct, 8).ToString("X")}");
                            break;
                        }

                    case "DB":
                        {
                            Console.Write("Enter decimal number: ");
                            string dec = Console.ReadLine();
                            Console.WriteLine($"{dec} to binary is {Convert.ToString(Convert.ToInt32(dec, 10), 2)} ");
                            break;
                        }

                    case "DO":
                        {
                            Console.Write("Enter decimal number: ");
                            string dec = Console.ReadLine();
                            Console.WriteLine($"{dec} to octal is {Convert.ToString(Convert.ToInt32(dec, 10), 8)} ");
                            break;
                        }

                    case "DH":
                        {
                            Console.Write("Enter decimal number: ");
                            string dec = Console.ReadLine();
                            Console.WriteLine($"{dec} to hexadecimal is {Convert.ToInt32(dec, 10).ToString("X")}");
                            break;
                        }

                    case "HB":
                        {
                            Console.Write("Enter hexadecimal number: ");
                            string hex = Console.ReadLine();
                            Console.WriteLine($"{hex} to binary is {Convert.ToString(Convert.ToInt32(hex, 16), 2)} ");
                            break;
                        }

                    case "HO":
                        {
                            Console.Write("Enter hexadecimal number: ");
                            string hex = Console.ReadLine();
                            Console.WriteLine($"{hex} to octal is {Convert.ToString(Convert.ToInt32(hex, 16), 8)} ");
                            break;
                        }

                    case "HD":
                        {
                            Console.Write("Enter hexadecimal number: ");
                            string hex = Console.ReadLine();
                            Console.WriteLine($"{hex} to decimal is {Convert.ToString(Convert.ToInt32(hex, 16), 10)} ");
                            break;
                        }

                    default:
                        Console.WriteLine("What do you expect to happen. ");
                        break;
                }
            }
        }
    }
}
