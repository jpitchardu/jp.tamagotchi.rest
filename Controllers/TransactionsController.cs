using jp.tamagotchi.rest.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace jp.tamagotchi.rest.Controllers
{
    [Route("api/[controller]")]
    public class TransactionsController : Controller
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
        public IActionResult Create([FromBody] Transaction Transaction)
        {
            return Created($"api/Transactions/{Transaction.Id}", Transaction);
        }

        [HttpPut("/{id}")]
        public IActionResult Update(int id, [FromBody] Transaction Transaction)
        {
            return Ok(Transaction);
        }

        [HttpDelete("/{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

    }
}