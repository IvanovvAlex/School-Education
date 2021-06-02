using BookStoreConsoleApp.Core;
using System.ComponentModel.DataAnnotations;
using Microsoft.Data.SqlClient;
using System.Data;
using System;

namespace BookStoreConsoleApp.Models
{
    public class Book
    {
        public Book()
        {

        }
        public Book(int id, string name, int isbn, int genresId)
        {
            BooksID = id;
            BooksName = name;
            BooksISBN = isbn;
            GenresID = genresId;

        }

        [Key, Required]
        public int BooksID { get; private set; }
        [Required]
        public string BooksName { get; private set; }
        [Required]
        public int BooksISBN { get; private set; }
        [Required]
        public int GenresID { get; private set; }
        public string Create(ContextDB db)
        {
            if (BooksID != null && BooksName != string.Empty && BooksISBN != null && GenresID != null)
            {
                Engine.cmd = new SqlCommand($"insert into Books(BooksID,BooksName,BooksISBN,GenresID) values(@id,@name,@isbn, @genreId)", Engine.con);
                Engine.con.Open();
                Engine.cmd.Parameters.AddWithValue("@id", BooksID);
                Engine.cmd.Parameters.AddWithValue("@name", BooksName);
                Engine.cmd.Parameters.AddWithValue("@isbn", BooksISBN);
                Engine.cmd.Parameters.AddWithValue("@genreId", GenresID);
                Engine.cmd.ExecuteNonQuery();
                Engine.con.Close();
                db.SaveChanges();
                Console.WriteLine(Utilities.Messages.OutputMessages.Successful);
            }
            return Utilities.Messages.ExceptionMessages.IncorrectInputMessege;
        }
        public static void Read(ContextDB db)
        {
            Console.Clear();
            Engine.con.Open();
            DataTable dt = new DataTable();
            var adapt = new SqlDataAdapter("select * from Books", Engine.con);
            adapt.Fill(dt);
            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write(item + "  ");
                }
                Console.WriteLine();
            }
            Engine.con.Close();
            db.SaveChanges();
            Console.WriteLine(Utilities.Messages.OutputMessages.Successful);
        }
        public string Update(ContextDB db)
        {
            if (BooksID != null && BooksName != string.Empty && BooksISBN != null && GenresID != null)
            {
                Engine.cmd = new SqlCommand("update Genres set BooksName=@name,BooksISBN=@isbn,GenresID=@GenresID where BooksID=@id", Engine.con);
                Engine.con.Open();
                Engine.cmd.Parameters.AddWithValue("@id", BooksID);
                Engine.cmd.Parameters.AddWithValue("@name", BooksName);
                Engine.cmd.Parameters.AddWithValue("@isbn", BooksISBN);
                Engine.cmd.Parameters.AddWithValue("@GenresID", GenresID);
                Engine.cmd.ExecuteNonQuery();
                Engine.con.Close();
                db.SaveChanges();
                Console.WriteLine(Utilities.Messages.OutputMessages.Successful);
            }
            return Utilities.Messages.ExceptionMessages.IncorrectInputMessege;
        }
        public string Delete(ContextDB db)
        {
            if (BooksID != 0)
            {
                Engine.cmd = new SqlCommand("delete Books where BooksID=@id", Engine.con);
                Engine.con.Open();
                Engine.cmd.Parameters.AddWithValue("@id", GenresID);
                Engine.cmd.ExecuteNonQuery();
                Engine.con.Close();
                db.SaveChanges();
                Console.WriteLine(Utilities.Messages.OutputMessages.Successful);
            }
            return Utilities.Messages.ExceptionMessages.IncorrectInputMessege;
        }
        public void Filter(ContextDB db)
        {

            Engine.con.Open();
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("Select * from Books where BooksName=@name", Engine.con);
            command.Parameters.AddWithValue("@name", BooksName);
            SqlDataAdapter data = new SqlDataAdapter(command);
            data.Fill(dt);
            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write(item + "  ");
                }
                Console.WriteLine();
            }
            Engine.con.Close();
            db.SaveChanges();
            Console.WriteLine(Utilities.Messages.OutputMessages.Successful);
        }
    }
}