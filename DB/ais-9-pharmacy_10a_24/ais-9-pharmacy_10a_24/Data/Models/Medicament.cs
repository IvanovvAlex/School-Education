using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ais_9_pharmacy_10a_24.Data.Models
{
    public class Medicament
    {
        [Required]
        [MaxLength(150)]
        [Key]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }

        [MaxLength(150)]
        public string Type { get; set; }
    }
}
