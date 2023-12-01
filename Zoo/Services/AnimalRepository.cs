using Microsoft.EntityFrameworkCore;
using Zoo.DbContexts;
using Zoo.Entities;

namespace Zoo.Services
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly AnimalContext _context;

        public AnimalRepository(AnimalContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Animal>> GetAllAnimalsAsync()
        {
            return await _context.Animals.ToListAsync();
        }

        public async Task<Animal?> GetAnimalAsync(int animalId)
        {
            return await _context.Animals.Where(a => a.Id == animalId).FirstOrDefaultAsync();
        }

        public async Task CreateAnimalAsync(Animal animal)
        {
            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAnimalAsync(Animal animal)
        {
            _context.Animals.Remove(animal);
            await _context.SaveChangesAsync();
        }
    }
}