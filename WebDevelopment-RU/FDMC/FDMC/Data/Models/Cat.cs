using System.ComponentModel.DataAnnotations;

namespace FDMC.Data.Models
{
    public class Cat
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string BreedId { get; set; }

        [Required]
        public virtual Breed Breed { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
