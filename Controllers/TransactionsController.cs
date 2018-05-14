using System.Collections.Generic;
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
            var response = new Response<Transaction>();

            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetMultiple()
        {
            var response = new Response<List<Transaction>>();

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Transaction transaction)
        {
            var response = new Response<Transaction>()
            {
                Data = transaction
            };

            return Created($"api/Transactions/{transaction.Id}", response);
        }

        [HttpPut("/{id}")]
        public IActionResult Update(int id, [FromBody] Transaction transaction)
        {
            var response = new Response<Transaction>()
            {
                Data = transaction
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