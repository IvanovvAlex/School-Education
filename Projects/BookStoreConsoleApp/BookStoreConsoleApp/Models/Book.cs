using System.ComponentModel.DataAnnotations;

namespace BookStoreConsoleApp.Models
{
    public class Book
    {
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
    }
}