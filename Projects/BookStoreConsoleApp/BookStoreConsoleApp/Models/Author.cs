using BookStoreConsoleApp.Core;
using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel.DataAnnotations;

namespace BookStoreConsoleApp.Models
{
    public class Author
    {
        public Author()
        {

        }
        public Author(int id, string name)
        {
            AuthorsID = id;
            AuthorsName = name;
        }

        [Key, Required]
        public int AuthorsID { get; private set; }
        [Required]
        public string AuthorsName { get; private set; }
        public string Create(ContextDB db)
        {
            if (AuthorsID != null && AuthorsName != string.Empty)
            {
                Engine.cmd = new SqlCommand($"insert into Authors(AuthorsID,AuthorsName) values(@id,@name)", Engine.con);
                Engine.con.Open();                
                Engine.cmd.Parameters.AddWithValue("@id", AuthorsID);
                Engine.cmd.Parameters.AddWithValue("@name", AuthorsName);
                Engine.cmd.ExecuteNonQuery();
                Engine.con.Close();
                db.SaveChanges();
            }
            return Utilities.Messages.ExceptionMessages.IncorrectInputMessege;
        }
    }
}