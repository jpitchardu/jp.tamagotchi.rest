using jp.tamagotchi.rest.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace jp.tamagotchi.rest.Controllers
{
    [Route("api/[controller]")]
    public class PetsController : Controller
    {

        [HttpGet("/{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetMultiple()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Pet Pet)
        {
            return Created($"api/Pets/{Pet.Id}", Pet);
        }

        [HttpPut("/{id}")]
        public IActionResult Update(int id, [FromBody] Pet Pet)
        {
            return Ok(Pet);
        }

        [HttpDelete("/{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

    }
}