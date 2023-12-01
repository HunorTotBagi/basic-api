using Microsoft.EntityFrameworkCore;
using Zoo.Entities;

namespace Zoo.DbContexts
{
    public class AnimalContext : DbContext
    {
        public AnimalContext(DbContextOptions<AnimalContext> options) : base(options)
        {
        }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().HasData(
                new Animal()
                {
                    Id = 1,
                    Name = "Janos",
                    CityOrigin = "Hungary",
                    Weight = 150
                },
                new Animal()
                {
                    Id = 2,
                    Name = "Milojko",
                    CityOrigin = "Serbia",
                    Weight = 89
                },
                new Animal()
                {
                    Id = 3,
                    Name = "Klaus",
                    CityOrigin = "Germany",
                    Weight = 150
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}