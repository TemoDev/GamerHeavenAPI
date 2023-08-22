using GamerHeavenAPI.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<IEnumerable<Models.Console>>> GetConsoles() {
            var consoles = await _consoleContext.GetConsolesAsync();
            return Ok(consoles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Console>> GetConsole(int id)
        {
            var console = await _consoleContext.GetConsoleByIdAsync(id);
            return Ok(console);
        }

        [HttpPost]
        public async Task AddConsole(Models.Console console)
        {
            await _consoleContext.AddConsoleAsync(console);
            await _consoleContext.SaveChangesAsync();
        }

    }
}
