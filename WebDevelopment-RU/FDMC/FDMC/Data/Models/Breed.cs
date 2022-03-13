using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FDMC.Data.Models
{
    public class Breed
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Cat> Cats { get; set; }
    }
}