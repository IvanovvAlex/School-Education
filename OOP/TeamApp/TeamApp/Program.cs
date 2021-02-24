using System;
using System.Linq;

namespace TeamApp
{
    class Program
    {
        public string firstName;
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            string firstName = command[0];
            string secondName = command[1];
            int age = int.Parse(command[2]);

            Team firstPlayer = new Team(firstName, secondName, age);

            command = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            firstName = command[0];
            secondName = command[1];
            age = int.Parse(command[2]);

            Team secondPlayer = new Team(firstName, secondName, age);

            command = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            firstName = command[0];
            secondName = command[1];
            age = int.Parse(command[2]);

            Team thirdPlayer = new Team(firstName, secondName, age);

            command = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            firstName = command[0];
            secondName = command[1];
            age = int.Parse(command[2]);

            Team fourPlayer = new Team(firstName, secondName, age);

            command = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            firstName = command[0];
            secondName = command[1];
            age = int.Parse(command[2]);

            Team fifthPlayer = new Team(firstName, secondName, age);

            Team[] players = new Team[] { firstPlayer, secondPlayer, thirdPlayer, fourPlayer, fifthPlayer };

            int firstTeam = 0;
            int reserveTeam = 0;

            foreach (Team player in players)
            {
                if (player.age < 40)
                {
                    firstTeam++;
                }
                else
                {
                    reserveTeam++;
                }
            }

            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine($"First team: {firstTeam}");
            Console.ReadLine();
            Console.WriteLine($"Reserve team: {reserveTeam}");
        }


    }
}

