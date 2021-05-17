namespace BookStoreConsoleApp.IO
{
    using System;

    using BookStoreConsoleApp.IO.Contracts;

    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}