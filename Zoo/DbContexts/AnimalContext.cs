using Microsoft.EntityFrameworkCore;
using Zoo.Model;

namespace Zoo.DbContexts
{
    public class AnimalContext : DbContext
    {
        public AnimalContext(DbContextOptions<AnimalContext> options) : base(options)
        {
        }
        public DbSet<Animal> Animals { get; set; }

    }
}
