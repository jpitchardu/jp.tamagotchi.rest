using System.Collections.Generic;

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
            var result = new Response<Pet>();

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetMultiple()
        {
            var result = new Response<List<Pet>>();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Pet pet)
        {
            var result = new Response<Pet>()
            {
                Data = pet
            };

            return Created($"api/Pets/{pet.Id}", result);
        }

        [HttpPut("/{id}")]
        public IActionResult Update(int id, [FromBody] Pet pet)
        {
            var result = new Response<Pet>()
            {
                Data = pet
            };

            return Ok(result);
        }

        [HttpDelete("/{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

    }
}