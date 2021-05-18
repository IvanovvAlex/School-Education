﻿
using System;
using BookStoreConsoleApp.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using BookStoreConsoleApp.Core.Contracts;
using BookStoreConsoleApp.Models;
using System.Data.SqlClient;
using System.Data;

namespace BookStoreConsoleApp.Core
{
    
    public class Controller 
    {
        
        public static void Create(ContextDB db)
        {               
            Console.WriteLine(Utilities.Messages.OutputMessages.InfoStringForTable);
            string table = Console.ReadLine();
            switch (table)
            {
                case "Genres":
                    string[] input = ReadingInputGenreAndAuthor();
                    Genre genre = new Genre(int.Parse(input[0]) /*id*/, input[1] /*name*/);
                    genre.Create(db);                    
                    break;

                case "Authors":
                    input = ReadingInputGenreAndAuthor();
                    Author author = new Author(int.Parse(input[0]) /*id*/, input[1] /*name*/);
                    author.Create(db);
                    break;

                case "Books":
                    input = ReadingInputBook();
                    Book book = new Book(int.Parse(input[0]) /*id*/, input[1] /*name*/, int.Parse(input[2]) /*ISBN*/, int.Parse(input[3]) /*GenreID*/);
                    book.Create(db);
                    break;

                default:
                    Console.WriteLine(Utilities.Messages.ExceptionMessages.IncorrectInputMessege);
                    break;
            }
        }        

        public static void Read(ContextDB db)
        {
            Console.WriteLine(Utilities.Messages.OutputMessages.InfoStringForTable);
        }      
        public static void Update(ContextDB db)
        {
            Console.WriteLine(Utilities.Messages.OutputMessages.InfoStringForTable);
        }      
        public static void Delete(ContextDB db)
        {
            Console.WriteLine(Utilities.Messages.OutputMessages.InfoStringForTable);
        }
        public static string[] ReadingInputGenreAndAuthor()
        {
            Console.Clear();
            Console.Write("Enter id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            return new string[] { $"{id}", name };
        }
        private static string[] ReadingInputBook()
        {
            Console.Clear();
            Console.Write("Enter id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter isbn: ");
            int isbn = int.Parse(Console.ReadLine());
            Console.Write("Enter GenreID: ");
            int genreId = int.Parse(Console.ReadLine());
            return new string[] { $"{id}", name, $"{isbn}", $"{genreId}" };
        }
    }
}
