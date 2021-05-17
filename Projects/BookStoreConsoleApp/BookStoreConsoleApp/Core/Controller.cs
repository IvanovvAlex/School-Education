
using System;
using BookStoreConsoleApp.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using BookStoreConsoleApp.Core.Contracts;
using BookStoreConsoleApp.Models;
using System.Data.SqlClient;

namespace BookStoreConsoleApp.Core
{
    public class Controller 
    {
        
        public static void Create(ContextDB db)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3U20D3B;Initial Catalog=BookStoreDB;Integrated Security=True");
            SqlCommand cmd;
            
            
            Console.WriteLine(Utilities.Messages.OutputMessages.InfoStringForTable);
            string table = Console.ReadLine();
            switch (table)
            {
                case "Genres":
                    Console.Write("Enter id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();

                    Genre genre = new Genre(id, name);
                    if (id != null && name != string.Empty)
                    {
                        cmd = new SqlCommand("insert into Genres(GenresID,GenresName) values(@id,@name)", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        db.SaveChanges();
                        
                        
                    }
                    else
                    {
                       
                    }

                    break;
                case "Authors":
                    break;
                case "Books":
                    break;
                default:
                    Console.WriteLine(Utilities.Messages.ExceptionMessages.IncorrectInputMessege);
                    break;
            }
        }      
        public static void Read()
        {
            Console.WriteLine(Utilities.Messages.OutputMessages.InfoStringForTable);
        }      
        public static void Update()
        {
            Console.WriteLine(Utilities.Messages.OutputMessages.InfoStringForTable);
        }      
        public static void Delete()
        {
            Console.WriteLine(Utilities.Messages.OutputMessages.InfoStringForTable);
        }
    }
}
