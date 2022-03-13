namespace FDMC.Data
{
    using FDMC.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class AppFdmcDbContext : DbContext
    {
        public virtual DbSet<Cat> Cats { get; set; }
        public virtual DbSet<Breed> Breeds { get; set; }
        public AppFdmcDbContext(DbContextOptions<AppFdmcDbContext> options)
           : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

                var connectionString = configuration.GetConnectionString("fdmcDb");
                optionsBuilder.UseSqlServer(connectionString);
                optionsBuilder.UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // I wrote this only to you know that I know it, but it's not needed  xD
            //modelBuilder.Entity<Cat>().HasOne(c => c.Breed).WithMany(b => b.Cats);
        }
    }
}
