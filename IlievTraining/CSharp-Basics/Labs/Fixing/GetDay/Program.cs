using System;

namespace GetDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.Write(GetDay(num));
        }
       

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Monday";
                    break;

                case 1:
                    dayName = "Tuesday";
                    break;

                case 2:
                    dayName = "Wednesday";
                    break;

                case 3:
                    dayName = "Thursday";
                    break;

                case 4:
                    dayName = "Friday";
                    break;

                case 5:
                    dayName = "SAturday";
                    break;

                case 6:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "invalid day number";
                    break;
            }
            return dayName;
        }
    }
}
