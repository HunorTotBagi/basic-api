using Zoo.Entities;

namespace Zoo.Services
{
    public interface IAnimalRepository
    {
        Task<IEnumerable<Animal>> GetAllAnimalsAsync();
        Task<Animal?> GetAnimalAsync(int animalId);
        Task CreateAnimalAsync(Animal animal);
        Task DeleteAnimalAsync(Animal animal);
    }
}
