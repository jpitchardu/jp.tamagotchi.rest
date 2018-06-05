using System.Collections.Generic;

using jp.tamagotchi.rest.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace jp.tamagotchi.rest.Controllers
{
    [Route("api/[controller]")]
    public class PetOwnershipController : Controller
    {
        [HttpGet("/{id}")]
        public IActionResult GetSingle(int id)
        {
            var result = new Response<PetOwnership>();

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetMultiple()
        {
            var result = new Response<List<PetOwnership>>();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] PetOwnership petOwnership)
        {
            var result = new Response<PetOwnership>()
            {
                Data = petOwnership
            };

            return Created($"api/Pets/{petOwnership.Id}", result);
        }

        [HttpPut("/{id}")]
        public IActionResult Update(int id, [FromBody] PetOwnership petOwnership)
        {
            var result = new Response<PetOwnership>()
            {
                Data = petOwnership
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