using GamerHeavenAPI.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GamerHeavenAPI.Controllers
{
    [Route("api/consoles")]
    [ApiController]
    public class ConsolesController : ControllerBase
    {
        private readonly IConsoleRepository _consoleContext;
        
        public ConsolesController(IConsoleRepository consoleContext)
        {
            _consoleContext = consoleContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Console>>> GetConsoles(
            string? name, string? searchQuery, int pageNumber, int pageSize
            ) {
            var (consoles, paginationMedatada) = await _consoleContext.GetConsolesAsync(name, searchQuery, pageNumber, pageSize);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(paginationMedatada));

            if(consoles == null)
            {
                return NotFound();
            }
            return Ok(consoles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Console>> GetConsole(int id)
        {
            var console = await _consoleContext.GetConsoleByIdAsync(id);
            if(console == null) return NotFound();
            return Ok(console);
        }

        [HttpGet("{id}/controllers")]
        public async Task<ActionResult<IEnumerable<Models.Controller>>> GetConsoleController(int id)
        {
            var controllers = await _consoleContext.GetConsoleControllersAsync(id);
            if(controllers == null) { return NotFound(); }
            return Ok(controllers);
        }



        [HttpPost]
        public async Task<ActionResult<Models.Console>> AddConsole(Models.Console console)
        {
            await _consoleContext.AddConsoleAsync(console);
            await _consoleContext.SaveChangesAsync();

            return CreatedAtAction("GetConsole", 
                new
                {
                    Id = console.Id,
                }, console);
        }

    }
}
