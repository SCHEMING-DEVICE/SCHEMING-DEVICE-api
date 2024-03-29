using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Scheming.Device.Domain.Catalog;

namespace Scheming.Device.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new List<Item>()
            {
                new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
                new Item("Shorts", "Ohio State shirt.", "Nike", 49.99m)
            };
            return Ok(items);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id)
        {
            // Simulating getting an item by id from some data source.
            var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m)
            {
                Id = id  // Setting the ID to the one passed in.
            };
            
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Post(Item item)
        {
            return Created("/catalog/42",item);
        }
        [HttpPost("{id:int}/ratings")]
        public IActionResult PostRating(int id,[FromBody] Rating rating)
        {
            var item = new Item("Shirt", "Ohio State Shirt.", "Nike", 29.99m);
            item.Id = id;
            item.AddRating(rating);

            return Ok(item);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Item item)
        {
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
