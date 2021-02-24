using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split()
                .ToArray();

            Box<string> box = new Box<string>();

            while (command[0].ToLower() != "end")
            {
                string[] secondCommand = command;
                switch (command[0].ToLower())

                {
                    case "add":
                        box.Add(command[1]);
                        break;
                    case "remove":
                        box.Remove();
                        break;
                }

                command = Console.ReadLine()
                .Split()
                .ToArray();
            }
        }
    }
}
