using BookStoreConsoleApp.Core;
using System.ComponentModel.DataAnnotations;
using Microsoft.Data.SqlClient;

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
            }
            return Utilities.Messages.ExceptionMessages.IncorrectInputMessege;
        }
    }
}