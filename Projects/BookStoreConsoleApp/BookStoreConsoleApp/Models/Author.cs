using System.ComponentModel.DataAnnotations;

namespace BookStoreConsoleApp.Models
{
    public class Author
    {
        public Author(int id, string name)
        {
            AuthorsID = id;
            AuthorsName = name;
        }

        [Key, Required]
        public int AuthorsID { get; private set; }
        [Required]
        public string AuthorsName { get; private set; }
        public string Create()
        {
            return Utilities.Messages.ExceptionMessages.IncorrectInputMessege;
        }
    }
}