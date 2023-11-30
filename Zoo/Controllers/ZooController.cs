using Microsoft.AspNetCore.Mvc;
using Zoo.DbContexts;
using Zoo.Model;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("api/animals")]
    public class ZooController : ControllerBase
    {
        private readonly AnimalContext _context;

        public ZooController(AnimalContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            var items = _context.Animals.ToList();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetItem(int id)
        {
            var item = _context.Animals.Find(id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreateItem([FromBody] Animal item)
        {
            _context.Animals.Add(item);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetItem), new { id = item.Id }, item);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {
            var item = _context.Animals.Find(id);

            if (item == null)
                return NotFound();

            _context.Animals.Remove(item);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
