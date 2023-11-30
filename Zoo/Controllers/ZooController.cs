using Microsoft.AspNetCore.Mvc;
using Zoo.Entities;
using Zoo.Services;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("api/animals")]
    public class ZooController : ControllerBase
    {
        private readonly IAnimalRepository _animalRepository;
        public ZooController(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var items = await _animalRepository.GetAllAnimalsAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _animalRepository.GetAnimalAsync(id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem([FromBody] Animal item)
        {
            await _animalRepository.CreateAnimalAsync(item);

            return CreatedAtAction(nameof(GetItem), new { id = item.Id }, item);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = await _animalRepository.GetAnimalAsync(id);

            if (item == null)
                return NotFound();

            await _animalRepository.DeleteAnimalAsync(item);

            return NoContent();
        }
    }
}
