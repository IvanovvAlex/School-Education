using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using BookStoreConsoleApp.Core;

namespace BookStoreConsoleApp.Models
{
    public class Genre
    {
        public Genre()
        {

        }
        public Genre(int id, string name)
        {
            GenresID = id;
            GenresName = name;
        }

        [Key, Required]
        public int GenresID { get; private set; }
        [Required]
        public string GenresName { get; private set; }
        public string Create(ContextDB db)
        {
            if (GenresID != null && GenresName != string.Empty)
            {
                Engine.cmd = new SqlCommand($"insert into Genres(GenresID,GenresName) values(@id,@name)", Engine.con);
                Engine.con.Open();
                Engine.cmd.Parameters.AddWithValue("@id", GenresID);
                Engine.cmd.Parameters.AddWithValue("@name", GenresName);
                Engine.cmd.ExecuteNonQuery();
                Engine.con.Close();
                db.SaveChanges();
            }
            return Utilities.Messages.ExceptionMessages.IncorrectInputMessege;
        }
    }
}
