using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace BookStoreConsoleApp.Models
{
    public class Genre
    {
        public Genre(int id, string name)
        {
            GenresID = id;
            GenresName = name;
        }

        [Key, Required]
        public int GenresID { get; private set; }
        [Required]
        public string GenresName { get; private set; }
    }
}
