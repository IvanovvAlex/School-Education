using System;

namespace _07ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numOfProjects = int.Parse(Console.ReadLine());
            int hours = numOfProjects * 3;
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {numOfProjects} project/s.");
        }
    }
}
