using jp.tamagotchi.rest.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace jp.tamagotchi.rest.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
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
        public IActionResult Create([FromBody] User user)
        {
            return Created($"api/users/{user.Id}", user);
        }

        [HttpPut("/{id}")]
        public IActionResult Update(int id, [FromBody] User user)
        {
            return Ok(user);
        }

        [HttpDelete("/{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

    }
}