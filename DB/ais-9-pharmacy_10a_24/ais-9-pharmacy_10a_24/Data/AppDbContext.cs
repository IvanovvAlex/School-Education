using System;
using System.Collections.Generic;
using System.Text;
using ais_9_pharmacy_10a_24.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace ais_9_pharmacy_10a_24.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Medicament> Medicaments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ais9PharmacyDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
