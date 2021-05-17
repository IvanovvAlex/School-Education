namespace BookStoreConsoleApp.Core
{
    using System;

    using BookStoreConsoleApp.IO;
    using BookStoreConsoleApp.IO.Contracts;
    using BookStoreConsoleApp.Core.Contracts;
    using BookStoreConsoleApp.Models;

    public class Engine : IEngine
    {
        private IWriter writer;
        private IReader reader;
        private Controller controller;

        public Engine()
        {
            this.writer = new Writer();
            this.reader = new Reader();            
        }

        public void Run()
        {
            using (ContextDB db = new ContextDB())
            {
                writer.WriteLine(Utilities.Messages.OutputMessages.StartingMessage);
                while (true)
                {
                    
                    string[] input = reader.ReadLine().Split();
                    Console.Clear();
                    if (input[0] == ".exit")
                    {
                        Environment.Exit(0);                        
                    }
                    try
                    {
                        switch (input[0])
                        {
                            case ".help":
                                writer.WriteLine(Utilities.Messages.OutputMessages.HelpMessage);
                                break;
                            case ".create":
                                Controller.Create(db);
                                break;
                            case ".read":
                                Controller.Read();
                                break;
                            case ".update":
                                Controller.Update();
                                break;
                            case ".delete":
                                Controller.Delete();
                                break;
                            default:
                                writer.WriteLine(Utilities.Messages.ExceptionMessages.IncorrectInputMessege);
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                        //writer.WriteLine(ex.Message);
                    }
                    
                }
            }
        }
    }
}
