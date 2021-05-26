using BookStoreConsoleApp.Core;
using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

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
                Console.WriteLine(Utilities.Messages.OutputMessages.Successful);
                db.SaveChanges();
            }
            return Utilities.Messages.ExceptionMessages.IncorrectInputMessege;
        }
        public string Update(ContextDB db)
        {
            if (AuthorsID != null && AuthorsName != string.Empty)
            {
                Engine.cmd = new SqlCommand("update Authors set AuthorsName=@name where AuthorsID=@id", Engine.con);
                Engine.con.Open();
                Engine.cmd.Parameters.AddWithValue("@id", AuthorsID);
                Engine.cmd.Parameters.AddWithValue("@name", AuthorsName);
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
            var adapt = new SqlDataAdapter("select * from Authors", Engine.con);
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
        public string Delete(ContextDB db)
        {
            if (AuthorsID != 0)
            {
                Engine.cmd = new SqlCommand("delete Authors where AuthorsID=@id", Engine.con);
                Engine.con.Open();
                Engine.cmd.Parameters.AddWithValue("@id", AuthorsID);
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
            SqlCommand command = new SqlCommand("Select * from Authors where AuthorsName=@name", Engine.con);
            command.Parameters.AddWithValue("@name", AuthorsName);
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