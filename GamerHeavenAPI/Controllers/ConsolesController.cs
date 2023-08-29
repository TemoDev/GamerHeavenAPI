using GamerHeavenAPI.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
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
            string? name, string? searchQuery, int pageNumber = 1, int pageSize = 3
            ) {
            var paginationData = await _consoleContext.GetAsync(name, searchQuery, pageNumber, pageSize);

            if(paginationData.Items == null)
            {
                return NotFound();
            }
            return Ok(paginationData);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Console>> GetConsole(int id)
        {
            var console = await _consoleContext.GetByIdAsync(id);
            if(console == null) return NotFound();
            return Ok(console);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Models.Console>> AddConsole(Models.Console console)
        {
            await _consoleContext.AddAsync(console);
            await _consoleContext.SaveChangesAsync();

            return CreatedAtAction("AddConsole", 
                new
                {
                    Id = console.Id,
                }, console);
        }
    }
}
