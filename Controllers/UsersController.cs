using System.Collections.Generic;

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
            var response = new Response<User>();

            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetMultiple()
        {
            var response = new Response<List<User>>();

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            var response = new Response<User>()
            {
                Data = user
            };

            return Created($"api/Users/{user.Id}", response);
        }

        [HttpPut("/{id}")]
        public IActionResult Update(int id, [FromBody] User user)
        {
            var response = new Response<User>()
            {
                Data = user
            };

            return Ok(response);
        }

        [HttpDelete("/{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

    }
}