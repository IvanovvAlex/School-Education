using FDMC.Data.Models;

namespace FDMC.Models
{
    public class CatViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string BreedId { get; set; }
        public Breed Breed { get; set; }
        public string ImageUrl { get; set; }
    }
}
