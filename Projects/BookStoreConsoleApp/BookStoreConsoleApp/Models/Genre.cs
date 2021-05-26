using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using BookStoreConsoleApp.Core;
using System.Data;

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
                Console.WriteLine(Utilities.Messages.OutputMessages.Successful);
            }
            return Utilities.Messages.ExceptionMessages.IncorrectInputMessege;
        }
        public static void Read(ContextDB db)
        {

            Engine.con.Open();
            DataTable dt = new DataTable();
            var adapt = new SqlDataAdapter("select * from Genres", Engine.con);
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
            if (GenresID != null && GenresName != string.Empty)
            {
                Engine.cmd = new SqlCommand("update Genres set GenresName=@name where GenresID=@id", Engine.con);
                Engine.con.Open();
                Engine.cmd.Parameters.AddWithValue("@id", GenresID);
                Engine.cmd.Parameters.AddWithValue("@name", GenresName);
                Engine.cmd.ExecuteNonQuery();
                Engine.con.Close();
                db.SaveChanges();
                Console.WriteLine(Utilities.Messages.OutputMessages.Successful);
            }
            return Utilities.Messages.ExceptionMessages.IncorrectInputMessege;
        }
        public string Delete(ContextDB db)
        {
            if (GenresID != 0)
            {
                Engine.cmd = new SqlCommand("delete Genres where GenresID=@id", Engine.con);
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
            SqlCommand command = new SqlCommand("Select * from Genres where GenresName=@name", Engine.con);
            command.Parameters.AddWithValue("@name", GenresName);
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
